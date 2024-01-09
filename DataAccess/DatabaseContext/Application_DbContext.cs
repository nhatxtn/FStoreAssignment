using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DatabaseContext
{
    public class Application_DbContext
    {
        public SqlConnection connection;
        public string ConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", true, true).Build();
            return configuration["ConnectionStrings:DefaultConnection"];
        }

        public SqlConnection OpenConnection()
        {
            try
            {
                if (connection == null)
                {
                    connection = new SqlConnection(ConnectionString());
                }
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

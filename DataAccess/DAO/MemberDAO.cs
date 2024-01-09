using BusinessObject;
using DataAccess.DatabaseContext;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class MemberDAO : Application_DbContext
    {
        //Create
        public void InsertMember(MemberObject member)
        {
            SqlCommand command = new SqlCommand("InsertMember", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Email", member.Email);
            command.Parameters.AddWithValue("@CompanyName", member.CompanyName);
            command.Parameters.AddWithValue("@City", member.City);
            command.Parameters.AddWithValue("@Country", member.Country);
            command.Parameters.AddWithValue("@Password", member.Password);

            command.ExecuteNonQuery();
            CloseConnection();
        }

        //Read
        public IEnumerable<MemberObject> GetMembers()
        {
            List<MemberObject> members = new List<MemberObject>();
            SqlCommand command = new SqlCommand("GetMembers", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                MemberObject member = new MemberObject();
                member.MemberId = reader.GetInt32(0);
                member.Email = reader.GetString(1);
                member.CompanyName = reader.GetString(2);
                member.City = reader.GetString(3);
                member.Country = reader.GetString(4);
                member.Password = reader.GetString(5);
                members.Add(member);
            }
            CloseConnection();
            return members;
        }

        //Update
        public void UpdateMember(MemberObject member)
        {
            SqlCommand command = new SqlCommand("UpdateMember", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@MemberId", member.MemberId);
            command.Parameters.AddWithValue("@Email", member.Email);
            command.Parameters.AddWithValue("@CompanyName", member.CompanyName);
            command.Parameters.AddWithValue("@City", member.City);
            command.Parameters.AddWithValue("@Country", member.Country);
            command.Parameters.AddWithValue("@Password", member.Password);

            command.ExecuteNonQuery();
            CloseConnection();
        }

        //Delete
        public void DeleteMember(MemberObject member)
        {
            SqlCommand command = new SqlCommand("DeleteMember", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@MemberId", member.MemberId);

            command.ExecuteNonQuery();
            CloseConnection();
        }

        public bool CheckCredentials(string username, string password)
        {
            SqlCommand command = new SqlCommand("CheckCredentials", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@Email", username);
            command.Parameters.AddWithValue("@Password", password);

            SqlParameter outputParam = new SqlParameter("@IsValid", SqlDbType.Bit);
            outputParam.Direction = ParameterDirection.Output;
            command.Parameters.Add(outputParam);

            command.ExecuteNonQuery();
            bool isValid = Convert.ToBoolean(outputParam.Value);
            
            return isValid;
        }
    }
}

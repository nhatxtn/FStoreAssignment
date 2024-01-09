using BusinessObject;
using DataAccess.DatabaseContext;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class ProductDAO : Application_DbContext
    {
        public void InsertProduct(ProductObject product)
        {
            SqlCommand command = new SqlCommand("InsertProduct", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@Weight", product.Weight);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@UnitsInStock", product.UnitsInStock);

            command.ExecuteNonQuery();
            CloseConnection();
        }

        //Read
        public IEnumerable<ProductObject> GetProducts()
        {
            List<ProductObject> products = new List<ProductObject>();
            SqlCommand command = new SqlCommand("GetProducts", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ProductObject product = new ProductObject();
                product.ProductId = reader.GetInt32(0);
                product.CategoryId = reader.GetInt32(1);
                product.ProductName = reader.GetString(2);
                product.Weight = reader.GetString(3);
                product.UnitPrice = reader.GetDecimal(4);
                product.UnitsInStock = reader.GetInt32(5);
                products.Add(product);
            }
            CloseConnection();
            return products;
        }

        //Update
        public void UpdateProduct(ProductObject product)
        {
            SqlCommand command = new SqlCommand("UpdateProduct", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ProductId", product.ProductId);
            command.Parameters.AddWithValue("@CategoryId", product.CategoryId);
            command.Parameters.AddWithValue("@ProductName", product.ProductName);
            command.Parameters.AddWithValue("@Weight", product.Weight);
            command.Parameters.AddWithValue("@UnitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@UnitsInStock", product.UnitsInStock);

            command.ExecuteNonQuery();
            CloseConnection();
        }

        //Delete
        public void DeleteProduct(ProductObject product)
        {
            SqlCommand command = new SqlCommand("DeleteProduct", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@ProductId", product.ProductId);

            command.ExecuteNonQuery();
            CloseConnection();
        }
    }
}

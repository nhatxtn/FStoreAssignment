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
    public class OrderDAO : Application_DbContext
    {
        //Create
        public void InsertOrder(OrderObject order)
        {
            SqlCommand command = new SqlCommand("InsertOrder", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@MemberId", order.MemberId);
            command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
            command.Parameters.AddWithValue("@RequiredDate", order.RequiredDate);
            command.Parameters.AddWithValue("@ShippedDate", order.ShippedDate);
            command.Parameters.AddWithValue("@Freight", order.Freight);

            command.ExecuteNonQuery();
            CloseConnection();
        }

        //Read
        public IEnumerable<OrderObject> GetOrders()
        {
            List<OrderObject> orders = new List<OrderObject>();
            SqlCommand command = new SqlCommand("GetOrders", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                OrderObject order = new OrderObject();
                order.OrderId = reader.GetInt32(0);
                order.MemberId = reader.GetInt32(1);
                order.OrderDate = reader.GetDateTime(2);
                order.RequiredDate = reader.GetDateTime(3);
                order.ShippedDate = reader.GetDateTime(4);
                order.Freight = reader.GetDecimal(5);
                orders.Add(order);
            }
            CloseConnection();
            return orders;
        }

        //Update
        public void UpdateOrder(OrderObject order)
        {
            SqlCommand command = new SqlCommand("UpdateOrder", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OrderId", order.OrderId);
            command.Parameters.AddWithValue("@MemberId", order.MemberId);
            command.Parameters.AddWithValue("@OrderDate", order.OrderDate);
            command.Parameters.AddWithValue("@RequiredDate", order.RequiredDate);
            command.Parameters.AddWithValue("@ShippedDate", order.ShippedDate);
            command.Parameters.AddWithValue("@Freight", order.Freight);

            command.ExecuteNonQuery();
            CloseConnection();
        }

        //Delete
        public void DeleteOrder(OrderObject order)
        {
            SqlCommand command = new SqlCommand("DeleteOrder", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OrderId", order.OrderId);

            command.ExecuteNonQuery();
            CloseConnection();
        }
    }
}

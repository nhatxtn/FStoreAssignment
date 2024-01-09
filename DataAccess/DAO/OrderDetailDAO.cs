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
    public class OrderDetailDAO : Application_DbContext
    {
        //Create
        public void InsertOrderDetail(OrderDetailObject orderDetail)
        {
            SqlCommand command = new SqlCommand("InsertOrderDetail", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OrderId", orderDetail.OrderId);
            command.Parameters.AddWithValue("@ProductId", orderDetail.ProductId);
            command.Parameters.AddWithValue("@UnitPrice", orderDetail.UnitPrice);
            command.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);
            command.Parameters.AddWithValue("@Discount", orderDetail.Discount);

            command.ExecuteNonQuery();
            CloseConnection();
        }

        //Read
        public IEnumerable<OrderDetailObject> GetOrderDetails()
        {
            List<OrderDetailObject> orderDetails = new List<OrderDetailObject>();
            SqlCommand command = new SqlCommand("GetOrderDetails", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                OrderDetailObject orderDetail = new OrderDetailObject();
                orderDetail.OrderId = reader.GetInt32(0);
                orderDetail.ProductId = reader.GetInt32(1);
                orderDetail.UnitPrice = reader.GetDecimal(2);
                orderDetail.Quantity = reader.GetInt32(3);
                orderDetail.Discount = reader.GetFloat(4);
                orderDetails.Add(orderDetail);
            }
            CloseConnection();
            return orderDetails;
        }

        //Update
        public void UpdateOrderDetail(OrderDetailObject orderDetail)
        {
            SqlCommand command = new SqlCommand("UpdateOrderDetail", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OrderId", orderDetail.OrderId);
            command.Parameters.AddWithValue("@ProductId", orderDetail.ProductId);
            command.Parameters.AddWithValue("@UnitPrice", orderDetail.UnitPrice);
            command.Parameters.AddWithValue("@Quantity", orderDetail.Quantity);
            command.Parameters.AddWithValue("@Discount", orderDetail.Discount);

            command.ExecuteNonQuery();
            CloseConnection();
        }

        //Delete
        public void DeleteOrderDetail(OrderDetailObject orderDetail)
        {
            SqlCommand command = new SqlCommand("DeleteOrderDetail", OpenConnection());
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OrderId", orderDetail.OrderId);

            command.ExecuteNonQuery();
            CloseConnection();
        }
    }
}

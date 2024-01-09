using BusinessObject;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public void DeleteOrderDetail(OrderDetailObject orderDetail)
                => DAOFactory.GetInstance<OrderDetailDAO>().DeleteOrderDetail(orderDetail);

        public IEnumerable<OrderDetailObject> GetOrderDetails()
                => DAOFactory.GetInstance<OrderDetailDAO>().GetOrderDetails();

        public void InsertOrderDetail(OrderDetailObject orderDetail)
               => DAOFactory.GetInstance<OrderDetailDAO>().InsertOrderDetail(orderDetail);

        public void UpdateOrderDetail(OrderDetailObject orderDetail)
               => DAOFactory.GetInstance<OrderDetailDAO>().UpdateOrderDetail(orderDetail);
    }
}

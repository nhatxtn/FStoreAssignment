using BusinessObject;
using DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void DeleteOrder(OrderObject order)
                => DAOFactory.GetInstance<OrderDAO>().DeleteOrder(order);

        public IEnumerable<OrderObject> GetOrders()
                => DAOFactory.GetInstance<OrderDAO>().GetOrders();

        public void InsertOrder(OrderObject order)
                => DAOFactory.GetInstance<OrderDAO>().InsertOrder(order);

        public void UpdateOrder(OrderObject order)
                => DAOFactory.GetInstance<OrderDAO>().UpdateOrder(order);
    }
}

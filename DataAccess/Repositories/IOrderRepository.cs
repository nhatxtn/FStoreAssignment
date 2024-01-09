using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IOrderRepository
    {
        void InsertOrder(OrderObject order);
        IEnumerable<OrderObject> GetOrders();
        void UpdateOrder(OrderObject order);
        void DeleteOrder(OrderObject order);
    }
}

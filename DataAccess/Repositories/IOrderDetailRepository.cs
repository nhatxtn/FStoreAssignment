using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public interface IOrderDetailRepository
    {
        void InsertOrderDetail(OrderDetailObject orderDetail);
        IEnumerable<OrderDetailObject> GetOrderDetails();
        void UpdateOrderDetail(OrderDetailObject orderDetail);
        void DeleteOrderDetail(OrderDetailObject orderDetail);
    }
}

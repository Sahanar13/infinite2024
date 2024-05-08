using Question_1.Models;
using System.Collections.Generic;
using System.Linq;

namespace Question_1.Repositories
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetAllOrderDetails();
        OrderDetail GetOrderDetailById(int id);
        void AddOrderDetail(OrderDetail orderDetail);
        void UpdateOrderDetail(OrderDetail orderDetail);
        void DeleteOrderDetail(OrderDetail orderDetail);
        bool OrderDetailExists(int id);
    }
}
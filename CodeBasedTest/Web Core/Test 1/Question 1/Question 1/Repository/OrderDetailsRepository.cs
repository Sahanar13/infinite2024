using Question_1.Models;
using Question_1.Repositories;

namespace Question_1.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly EkartContext _context;

        public OrderDetailRepository(EkartContext context)
        {
            _context = context;
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return _context.OrderDetails.ToList();
        }

        public OrderDetail GetOrderDetailById(int id)
        {
            return _context.OrderDetails.Find(id);
        }

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            _context.OrderDetails.Add(orderDetail);
            _context.SaveChanges();
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            _context.OrderDetails.Update(orderDetail);
            _context.SaveChanges();
        }

        public void DeleteOrderDetail(OrderDetail orderDetail)
        {
            _context.OrderDetails.Remove(orderDetail);
            _context.SaveChanges();
        }

        public bool OrderDetailExists(int id)
        {
            return _context.OrderDetails.Any(o => o.OrderDetailId == id);
        }
    }
}
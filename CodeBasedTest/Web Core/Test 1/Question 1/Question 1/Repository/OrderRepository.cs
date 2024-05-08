using System.Collections.Generic;
using System.Linq;
using Question_1.Models;

namespace Question_1.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly EkartContext _context;

        public OrderRepository(EkartContext context)
        {
            _context = context;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public Order GetOrderById(int id)
        {
            return _context.Orders.FirstOrDefault(o => o.OrderId == id);
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(int id)
        {
            var order = _context.Orders.Find(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        public object PlaceOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}

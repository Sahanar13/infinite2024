using Microsoft.AspNetCore.Mvc;
using Question_1.Models;
using Question_1.Repositories;

namespace Question_1.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        // GET: /Order/
        public IActionResult Index()
        {
            var orders = _orderRepository.GetAllOrders();
            return View(orders);
        }

        // GET: /Order/Details/5
        public IActionResult Details(int id)
        {
            var order = _orderRepository.GetOrderById(id);
            return View(order);
        }

        // GET: /Order/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                _orderRepository.AddOrder(order);
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: /Order/Edit/5
        public IActionResult Edit(int id)
        {
            var order = _orderRepository.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: /Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _orderRepository.UpdateOrder(order);
                return RedirectToAction(nameof(Index));
            }
            return View(order);
        }

        // GET: /Order/Delete/5
        public IActionResult Delete(int id)
        {
            var order = _orderRepository.GetOrderById(id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: /Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _orderRepository.DeleteOrder(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

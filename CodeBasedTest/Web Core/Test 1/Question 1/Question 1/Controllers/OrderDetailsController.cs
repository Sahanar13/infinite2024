using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Question_1.Models;
using Question_1.Repositories;

namespace Question_1.Controllers
{
    public class OrderDetailController : Controller
    {
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailController(IOrderDetailRepository orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }

        // GET: OrderDetail
        public IActionResult Index()
        {
            var orderDetails = _orderDetailRepository.GetAllOrderDetails();
            return View(orderDetails);
        }

        // GET: OrderDetail/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = _orderDetailRepository.GetOrderDetailById(id.Value);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // GET: OrderDetail/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrderDetail/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("ProductName, Quantity, UnitPrice")] OrderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                _orderDetailRepository.AddOrderDetail(orderDetail);
                return RedirectToAction(nameof(Index));
            }
            return View(orderDetail);
        }

        // GET: OrderDetail/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = _orderDetailRepository.GetOrderDetailById(id.Value);
            if (orderDetail == null)
            {
                return NotFound();
            }
            return View(orderDetail);
        }

        // POST: OrderDetail/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("OrderDetailId, OrderId, ProductName, Quantity, UnitPrice")] OrderDetail orderDetail)
        {
            if (id != orderDetail.OrderDetailId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _orderDetailRepository.UpdateOrderDetail(orderDetail);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_orderDetailRepository.OrderDetailExists(orderDetail.OrderDetailId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(orderDetail);
        }

        // GET: OrderDetail/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderDetail = _orderDetailRepository.GetOrderDetailById(id.Value);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // POST: OrderDetail/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var orderDetail = _orderDetailRepository.GetOrderDetailById(id);
            _orderDetailRepository.DeleteOrderDetail(orderDetail);
            return RedirectToAction(nameof(Index));
        }
    }
}

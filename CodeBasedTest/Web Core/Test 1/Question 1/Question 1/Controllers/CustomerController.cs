using Microsoft.AspNetCore.Mvc;
using Question_1.Models;
using Question_1.Repositories;

namespace Question_1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: /Customer/
        public IActionResult Index()
        {
            var customers = _customerRepository.GetAllCustomers();
            return View(customers);
        }

        // GET: /Customer/Details/5
        public IActionResult Details(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            return View(customer);
        }

        // GET: /Customer/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Customer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                _customerRepository.AddCustomer(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: /Customer/Edit/5
        public IActionResult Edit(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: /Customer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _customerRepository.UpdateCustomer(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: /Customer/Delete/5
        public IActionResult Delete(int id)
        {
            var customer = _customerRepository.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: /Customer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _customerRepository.DeleteCustomer(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

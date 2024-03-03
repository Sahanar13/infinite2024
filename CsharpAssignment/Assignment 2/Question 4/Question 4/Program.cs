using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    using System;

    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

        public Customer()
        {
            Console.WriteLine("Default constructor is called.");
        }

        
        public Customer(int customerId, string name, int age, string phone, string city)
        {
            CustomerId = customerId;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
        }

        
        public static void DisplayCustomer(Customer customer)
        {
            Console.WriteLine($"Customer ID: {customer.CustomerId}");
            Console.WriteLine($"Name: {customer.Name}");
            Console.WriteLine($"Age: {customer.Age}");
            Console.WriteLine($"Phone: {customer.Phone}");
            Console.WriteLine($"City: {customer.City}");
            Console.ReadKey();
        }

        
        ~Customer()
        {
            Console.WriteLine("Destructor is called.");
            Console.ReadKey();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(18, "Yash", 26, "1234567890", "Bangalore");

            
            Customer.DisplayCustomer(customer1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public class SaleDetails
    {
        private int salesNo;
        private int productNo;
        private double price;
        private DateTime dateOfSale;
        private int qty;
        private double totalAmount;

        public SaleDetails(int salesNo, int productNo, double price, DateTime dateOfSale, int qty)
        {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.dateOfSale = dateOfSale;
            this.qty = qty;
            Sales();
        }

        public void Sales()
        {
            totalAmount = qty * price;
        }

        public void ShowData()
        {
            Console.WriteLine($"Sales No: {salesNo}");
            Console.WriteLine($"Product No: {productNo}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Date of Sale: {dateOfSale}");
            Console.WriteLine($"Quantity: {qty}");
            Console.WriteLine($"Total Amount: {totalAmount}");
            Console.ReadKey();
        }
    }

    class Question_3
    {
        static void Main(string[] args)
        {
            SaleDetails sale = new SaleDetails(1001, 101, 10.5, DateTime.Now, 5);
            sale.ShowData();
        }
    }
}

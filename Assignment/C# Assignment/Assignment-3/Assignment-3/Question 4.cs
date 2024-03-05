using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{

    class Scholarship
    {
        public void Merit(int marks, double fees)
        {
            double scholarshipAmount = 0;


            if (marks >= 70 && marks <= 80)
            {
                scholarshipAmount = 0.20 * fees;
            }
            else if (marks > 80 && marks <= 90)
            {
                scholarshipAmount = 0.30 * fees;
            }
            else if (marks > 90)
            {
                scholarshipAmount = 0.50 * fees;
            }


            Console.WriteLine($"Scholarship amount: {scholarshipAmount}");
        }
    }

    class Question4
    {
        static void Main(string[] args)
        {

            Scholarship scholarship = new Scholarship();


            Console.WriteLine("Enter marks:");
            int marks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter fees:");
            double fees = double.Parse(Console.ReadLine());


            scholarship.Merit(marks, fees);

            Console.ReadLine();
        }
    }
}

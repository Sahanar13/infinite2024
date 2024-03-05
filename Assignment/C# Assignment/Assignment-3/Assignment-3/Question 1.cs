using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name:");
            string lastName = Console.ReadLine();

           
            Display(firstName, lastName);

            Console.ReadLine();
        }

        
        static void Display(string firstName, string lastName)
        {
           
            Console.WriteLine(firstName.ToUpper());
            Console.WriteLine(lastName.ToUpper());
            
        }
    }
}


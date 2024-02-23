using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!..Welcome to C#");
            Console.WriteLine("Enter Your First Name:");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your Last Name:");
            string lname = Console.ReadLine();
            Console.WriteLine("Your FirstName is : " + fname + "and your LastName is : " + lname); //concatenation
            Console.WriteLine("Your FirstName is :{0} and your LastName is :{1}", fname, lname);
        }
    }
}

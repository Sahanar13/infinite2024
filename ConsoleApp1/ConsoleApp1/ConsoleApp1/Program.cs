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

            Program program = new Program();
            program.type_Conversions();
            Console.Read();
        }

        
        public void type_Conversions()
        {
            int i = 100;
            float f;
            Console.WriteLine(i);
            f = i;  
            Console.WriteLine(f);
            f = 12345.56f;
            int x = (int)f; 
            Console.WriteLine(x);
            // x = Convert.ToInt32(f); 
            Console.WriteLine(x);

            

            string str = "100gms";
            x = int.Parse(str);
            Console.WriteLine("Value of X after parsing is " + x);

        }
    }
}

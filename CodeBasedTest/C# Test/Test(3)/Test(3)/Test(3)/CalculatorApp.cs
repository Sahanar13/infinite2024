using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_3_
{
    class CalculatorApp

    {
        
        delegate int CalculatorDelegate(int x, int y);

        static void Main(string[] args)
        {
            
            CalculatorDelegate addition = Add;
            CalculatorDelegate subtraction = Subtract;
            CalculatorDelegate multiplication = Multiply;

           
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            
            Console.WriteLine($"Addition: {addition(num1, num2)}");
            Console.WriteLine($"Subtraction: {subtraction(num1, num2)}");
            Console.WriteLine($"Multiplication: {multiplication(num1, num2)}");
            Console.ReadKey();
        }

        
        static int Add(int x, int y)
        {
            return x + y;
        }

        static int Subtract(int x, int y)
        {
            return x - y;
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}

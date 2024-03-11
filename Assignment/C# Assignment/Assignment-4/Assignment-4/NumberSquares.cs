using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class NumberSquares
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a list of numbers separated by commas:");
            string input = Console.ReadLine();
            string[] numbersString = input.Split(',');

            List<int> numbers = new List<int>();
            foreach (string numString in numbersString)
            {
                if (int.TryParse(numString, out int num))
                {
                    numbers.Add(num);
                }
                else
                {
                    Console.WriteLine($"Invalid input: {numString}. Skipping...");
                }
            }

            Console.WriteLine("Numbers and their squares greater than 20:");
            foreach (int number in numbers)
            {
                int square = number * number;
                if (square > 20)
                {
                    Console.WriteLine($"{number}: {square}");
                    Console.ReadKey();
                }

            }
        }
    }
}
            



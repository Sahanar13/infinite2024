using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Question_2
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            
            Console.WriteLine("Enter the letter to be counted:");
            char letter = Console.ReadLine()[0]; 

            
            int count = CountOccurrences(inputString, letter);

           
            Console.WriteLine($"The letter '{letter}' appears {count} times in the given string.");

            Console.ReadLine();
        }

        
        static int CountOccurrences(string inputString, char letter)
        {
            int count = 0;
            
            foreach (char c in inputString)
            {
               
                if (c == letter)
                {
                    count++;
                }
            }
            return count;
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ten_Marks
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    int i, n, sum = 0;  // Declaration of variables 'i' for iteration, 'n' to store each number, and 'sum' to store their total sum
        //    double avg;  // Declaration of variable 'avg' to store the average

        //    Console.Write("\n\n");
        //    Console.Write("Read 10 numbers and calculate sum and average:\n");
        //    Console.Write("----------------------------------------------");
        //    Console.Write("\n\n");

        //    Console.Write("Input the 10 numbers : \n");
        //    for (i = 1; i <= 10; i++)
        //    {
        //        Console.Write("Number-{0} :", i);

        //        n = Convert.ToInt32(Console.ReadLine());
        //        sum += n;
        //    }

        //    avg = sum / 10.0;


        //    Console.Write("The sum of 10 numbers is : {0}\nThe Average is : {1}\n", sum, avg);

        //    Console.ReadKey();
        //}
        // static void Main(string[] args)
        //{
        //    int[] arr1 = new int[100];  // Array to store elements
        //    int i, mx, mn, n;  // Variables for maximum, minimum, and size of array

        //    Console.Write("\n\nFind maximum and minimum element in an array :\n");
        //    Console.Write("--------------------------------------------------\n");

        //    Console.Write("Input the number of elements to be stored in the array :");
        //    n = Convert.ToInt32(Console.ReadLine());  // Read the number of elements

        //    Console.Write("Input {0} elements in the array :\n", n);
        //    for (i = 0; i < n; i++)
        //    {
        //        Console.Write("element - {0} : ", i);
        //        arr1[i] = Convert.ToInt32(Console.ReadLine());  // Read elements into the array
        //    }

        //    // Initializing maximum and minimum with the first element of the array
        //    mx = arr1[0];
        //    mn = arr1[0];

        //    // Finding maximum and minimum elements
        //    for (i = 1; i < n; i++)
        //    {
        //        if (arr1[i] > mx)  // If current element is greater than the current maximum
        //        {
        //            mx = arr1[i];  // Update maximum
        //        }

        //        if (arr1[i] < mn)  // If current element is smaller than the current minimum
        //        {
        //            mn = arr1[i];  // Update minimum
        //        }
        //    }

        //    // Display maximum and minimum elements
        //    Console.Write("Maximum element is : {0}\n", mx);
        //    Console.Write("Minimum element is : {0}\n\n", mn);
        //    Console.ReadKey();

        //}
        public static void Main()
        {
            int[] arr1 = new int[10]; // Declare an array to store integers
            int n, i, j, tmp; // Declare variables for array size, counting, and temporary storage

            // Display a message prompting the user to input the size of the array
            Console.Write("\n\nSort elements of array in ascending order :\n");
            Console.Write("----------------------------------------------\n");

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine()); // Read the size of the array entered by the user

            // Prompt the user to input 'n' elements in the array
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine()); // Store user input in the array
            }

            // Sort the elements of the array in ascending order using nested loops and swapping if needed
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i]) // Compare elements to arrange them in ascending order
                    {
                        tmp = arr1[i]; // Swap elements if the condition is met
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }

            // Display the sorted elements of the array in ascending order
            Console.Write("\nElements of array in sorted ascending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]); // Print sorted elements
            }
            Console.Write("\n\n"); // Print a new line for formatting
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Ten_Marks
    {
        //static void Main(string[] args)
        //{
        //    int i, n, sum = 0;  
        //    double avg;  

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
        static void Main(string[] args)
        {
            int[] arr1 = new int[100];
            int i, mx, mn, n;

            Console.Write("\n\nFind maximum and minimum element in an array :\n");
            Console.Write("--------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            mx = arr1[0];
            mn = arr1[0];


            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }

                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }


            Console.Write("Maximum element is : {0}\n", mx);
            Console.Write("Minimum element is : {0}\n\n", mn);
            Console.ReadKey();

        }
        public static void Main()
        {
            int[] arr1 = new int[10];
            int n, i, j, tmp;


            Console.Write("\n\nSort elements of array in ascending order :\n");
            Console.Write("----------------------------------------------\n");

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());


            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }


            Console.Write("\nElements of array in sorted ascending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");
            Console.ReadKey();
        }
    }
}
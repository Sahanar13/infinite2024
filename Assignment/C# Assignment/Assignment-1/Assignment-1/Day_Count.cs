using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Day_Count
    {
        static void Main(string[] args)
        {
            int dayno;

            Console.Write("\n\n");
            Console.Write("Accept day number and display its equivalent day name in word:\n");
            Console.Write("----------------------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input Day No : ");
            dayno = Convert.ToInt32(Console.ReadLine());

            switch (dayno)
            {
                case 1:
                    Console.Write("Monday \n");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Write("Tuesday \n");
                    Console.ReadKey();
                    ; break;
                case 3:
                    Console.Write("Wednesday \n");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Write("Thursday \n");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Write("Friday \n");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.Write("Saturday \n");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.Write("Sunday  \n");
                    Console.ReadKey();
                    break;
                default:
                    Console.Write("Invalid day number. \nPlease try again ....\n");

                    Console.ReadKey();

                    break;



            }
        }
    }
}
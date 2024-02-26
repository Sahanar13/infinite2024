using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_Count
{
    class Program
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

            switch (dayno)  // Switch statement based on the entered day number
            {
                case 1:
                    Console.Write("Monday \n");  // Displaying "Monday" for day number 1
                    break;
                case 2:
                    Console.Write("Tuesday \n");  // Displaying "Tuesday" for day number 2
                    break;
                case 3:
                    Console.Write("Wednesday \n");  // Displaying "Wednesday" for day number 3
                    break;
                case 4:
                    Console.Write("Thursday \n");  // Displaying "Thursday" for day number 4
                    break;
                case 5:
                    Console.Write("Friday \n");  // Displaying "Friday" for day number 5
                    break;
                case 6:
                    Console.Write("Saturday \n");  // Displaying "Saturday" for day number 6
                    break;
                case 7:
                    Console.Write("Sunday  \n");  
                    break;
                default:
                    Console.Write("Invalid day number. \nPlease try again ....\n");

                    Console.ReadKey();

                    break;

                    
                   
            }
        }
    }
}


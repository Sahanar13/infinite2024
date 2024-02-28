using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1_Test_1_
{
    class Class2
    {
        static void Main(string[] args)
        {

            Console.WriteLine(test("1234"));
            Console.WriteLine(test("1"));
            Console.WriteLine(test("89"));
            Console.ReadLine();
        }


        public static string test(string str)
        {

            return str.Length > 1

                ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1)

                : str;
        }
    }
}
    

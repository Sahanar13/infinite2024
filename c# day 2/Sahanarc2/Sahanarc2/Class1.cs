using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sahanarc2
{
    class Stings_Eg
    {
        public static object Strings_Eg { get; private set; }

        public static void String_Ops()
        {
            string s = "Sahana";
            Console.WriteLine("First Time is{0}", s.GetHashCode());
            s = "Sahana Gowda";
            Console.WriteLine("First Time is{ 0} ", s.GetHashCode());

            string s1 = "CSharp";
            Console.WriteLine("s1 is{ 0} ", s1.GetHashCode());

            string s2 = s1;
            Console.WriteLine("s2 is{ 0} ", s2.GetHashCode());

            string s3 = "Sahana";
            Console.WriteLine("s3 refernce is as same as{ 0} ", s3.GetHashCode());

            Console.WriteLine("--------Values of all String Objects------");
            Console.WriteLine(s + " " + s1 + " " + s2 + " " + s3);
            char[] carr = new char[] { 'w', 'e', 'l', 'c', 'o', 'm', 'e' };
            string mystring = new string(carr); 
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine("----Original hash of string builder-------");
            Console.WriteLine("Sbs hash code is {0} and the value is {1}", sb.GetHashCode(), sb);
            sb.Append(", C# String Builders");
            Console.WriteLine("----String Builder after changes----");
            Console.WriteLine("Sbs hash code is {0} and the value is {1}", sb.GetHashCode(), sb);



        }
    }
}

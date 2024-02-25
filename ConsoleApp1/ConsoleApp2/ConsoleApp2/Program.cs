using System;

namespace ConsoleApp2
{
    class Program
    {
        private static int x;

        static void Main(string[] args)
        {
            string str = "100gms";
            x = int.Parse(str);
            Console.WriteLine("Value of X after parsing is " + x);
            int result;
            bool success = int.TryParse(str, out result);

            if (success)
            {
                Console.WriteLine("The Parsed Number is {0}", result);
            }
            else
                Console.WriteLine("Invalid Data..Could not Parse");

        }

        public void Ref_value_conversion()
        {
            int i = 10;  
            object o;  

            o = i;  
            Console.WriteLine(o);
            float Marks;
            Console.WriteLine("Enter Marks :");
            Marks = float.Parse(Console.ReadLine());  
            Console.WriteLine("Marks thru Parse" + " " + Marks);
           

            Console.WriteLine("Enter Marks :");
            Marks = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Marks Thru Conversion " + " " + Marks);
            string s1 = "ABC";
            o = s1;   
            Console.WriteLine(s1);
            Console.WriteLine(o);
        }

        public void Nullable_Eg()
        {
            int? num1 = null;
            int num2;

            if (num1 == null)
            {
                num2 = 0;
            }
            else
                num2 = Convert.ToInt32(num1); 

            Console.WriteLine(num2);
        }
    }
}

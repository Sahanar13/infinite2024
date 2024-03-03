using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_DynamicBinding
{

    //public class NumberSwapper
    //{
    //    // Method to swap integers
    //    public void Swap(ref int a, ref int b)
    //    {
    //        int temp = a;
    //        a = b;
    //        b = temp;
    //    }

    //    // Method to swap doubles
    //    public void Swap(ref double a, ref double b)
    //    {
    //        double temp = a;
    //        a = b;
    //        b = temp;
    //    }

    //    // Method to swap any type using generics
    //    public void Swap<T>(ref T a, ref T b)
    //    {
    //        T temp = a;
    //        a = b;
    //        b = temp;
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        NumberSwapper swapper = new NumberSwapper();

    //        int x = 5, y = 10;
    //        double a = 2.5, b = 7.8;

    //        Console.WriteLine("Before swapping:");
    //        Console.WriteLine("x = " + x + ", y = " + y);
    //        Console.WriteLine("a = " + a + ", b = " + b);

    //        swapper.Swap(ref x, ref y); // Swap integers
    //        swapper.Swap(ref a, ref b); // Swap doubles

    //        Console.WriteLine("\nAfter swapping:");
    //        Console.WriteLine("x = " + x + ", y = " + y);
    //        Console.WriteLine("a = " + a + ", b = " + b);

    //        // Using dynamic loading (Generics)
    //        string str1 = "Hello", str2 = "World";
    //        Console.WriteLine("\nBefore swapping:");
    //        Console.WriteLine("str1 = " + str1 + ", str2 = " + str2);

    //        swapper.Swap(ref str1, ref str2); // Swap strings

    //        Console.WriteLine("\nAfter swapping:");
    //        Console.WriteLine("str1 = " + str1 + ", str2 = " + str2);
    //        Console.ReadKey();
    //    }
    //}
}


﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sahanarc4
{
    class StaticInstance
    {
        static void Main(string[] args)
        {
            StaticInstance Si = new StaticInstance();
            int sum = Si.AddNos(5, 6);  
            Console.WriteLine("The Sum of 2 Nos :{0}", sum);
            EvenNos_Generation(20);
            Console.WriteLine("===============");
            TestClass.Method1();
            Console.ReadKey();
        }

        public int AddNos(int a, int b) 
        {
            return a + b;
            Console.WriteLine(a + b);
            return a + b;
        }

        public static void EvenNos_Generation(int num)  
        {
            int i = 0;
            while (i <= num)
            {
                Console.WriteLine(i);
                i += 2;
            }
        }
    }
    class TestClass
    {
        public static void Method1()
        {
            Console.WriteLine("This is a static function of another class");
        }
    }
}

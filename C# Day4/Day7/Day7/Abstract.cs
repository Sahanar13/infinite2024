using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{


    class Travel
    {
        public int Dist { get; set; }
        public DateTime Traveldate { get; set; }

       
        public static Travel operator +(Travel tr1, Travel tr2)
        {
            Travel temp = new Travel();
            temp.Dist = tr1.Dist + tr2.Dist;
            return temp;
        }

       
        public static Travel operator ++(Travel tr)
        {
            tr.Dist++;
            return tr;
        }

       
        public static bool operator >=(Travel tr1, Travel tr2)
        {
            return tr1.Dist >= tr2.Dist;
        }

        
        public static bool operator <=(Travel tr1, Travel tr2)
        {
            return tr1.Dist <= tr2.Dist;
        }
    }

    class Operator_Overload
    {
        public static void Main()
        {
            Travel t1 = new Travel();
            Travel t2 = new Travel();
            t1.Dist = 45;
            t2.Dist = 20;

            
            Travel t3 = t1 + t2;
            Console.WriteLine("The total Distance To Travel is : " + t3.Dist);

            
            t3++;
            Console.WriteLine("After incrementing distance: " + t3.Dist);

           
            Console.WriteLine("Is t1 distance greater than or equal to t2? " + (t1 >= t2));

           
            Console.WriteLine("Is t1 distance less than or equal to t2? " + (t1 <= t2));

            Console.Read();
        }
    }
}









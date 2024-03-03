using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_DynamicBinding
{
    class Swap : SwapBase
    {
        public static void Swap(char char1, char char2)
        {
            char temp = char1;
            char1 = char2;
            char2 = temp;
            Console.WriteLine("Swapping of 2 characters, char 1 :{0} and char 2 {1} ", char1, char2);
        }
        static void Main(string[] args)
        {
            Swap(5, 10);  // go to line 12 //early binding
            Swap('a', 'z');
            Console.Read();
        }
    }
}
    

namespace Overloading_DynamicBinding
{
    internal class SwapBase
    {
        public static void Swap(int number1, int number2)
        {
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine("Swapping of 2 integers, number 1 {0} and number 2 {1}", number1, number2);

        }
    }
}
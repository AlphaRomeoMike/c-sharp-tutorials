using System;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, max, min;
            float e;
            a = 7;
            b = 12;
            c = a + b;
            d = b / a;
            e = b % a;
            max = int.MaxValue;
            min = int.MinValue;
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("The value of c is: " + c);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("See the integer value when it should be fractional or decimal: " + d + "." + e);
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine($"The minimum and maximum values are as follows: \nMinValue: {min}\nMaxValue: {max}");
            Console.WriteLine("-------------------------------------------------------");

        }
    }
}

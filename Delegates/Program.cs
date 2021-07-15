using System;

namespace Delegates
{
    public delegate void calc(int a, int b);
    class Program
    {
        public static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        static void Main(string[] args)
        {
            // Single casting
            calc c = new calc(add);
            c.Invoke(2, 3);
            c = sub;
            c(23, 4);

            // Multicasting
            calc b = new calc(add);
            b += sub;

            b(2, 1);
        }
    }
}

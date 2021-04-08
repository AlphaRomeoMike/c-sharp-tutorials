using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 6;

            // Simple IF ELSE 
            Console.WriteLine("IF ELSE STATEMETNT");
            if (a > b)
            {
                Console.WriteLine("A is greater than B");
            } else
            {
                Console.WriteLine("B is greater than A");
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("SWITCH CASE STATEMETNT");
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Day is Monday");
                    break;
                case 2:
                    Console.WriteLine("Day is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Day is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Day is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Day is Friday");
                    break;
                case 6:
                    Console.WriteLine("Day is Saturday");
                    break;
                default:
                    Console.WriteLine("Day is Sunday");
                    break;
            }
        }
    }
}

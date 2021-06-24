using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            int x = 5, y = 20;
            if(x > y)
            {
                if(x > y)
                {
                    Console.WriteLine("Value of x is greater than 10");
                }
                else
                {
                    Console.WriteLine("X is less than 10");
                }
            }
            else
            {
                if(y <= 20)
                {
                    Console.WriteLine("Y is less than or equal to 20");
                }
                else
                {
                    Console.WriteLine("Y is greater than 20");
                }

                Console.WriteLine("Press enter to exit");
            }
        }
    }
}

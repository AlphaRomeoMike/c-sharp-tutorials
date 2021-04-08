using System;

namespace Loops
{
    class Program
    {
        private const string Seperator = "-------------------------------------------------------";

        static void Main()
        {
            Console.WriteLine(Seperator);
            int counter = 0;
            for (counter = 0; counter <= 10; counter++)
            {
                Console.WriteLine("\t" + counter);
            }
            Console.WriteLine(Seperator);

            int loop = 0;
            do
            {
                Console.WriteLine(loop++);
            } while (loop <= 30);

            Console.WriteLine(Seperator);

            int row = 1;
            int col = 1;
            for(col = 1; col <= 5; ++col)
            {
                for(row = 1; row <= col; ++row)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

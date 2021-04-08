using System;

namespace Loops
{
    class Program
    {
        private const string Seperator = "-------------------------------------------------------";

        static void Main()
        {
            //To take User Input when we want a string
            Console.WriteLine("Enter Username");
            string username = Console.ReadLine();
            Console.WriteLine(Seperator);

            /*To take User Input when
             * we want a interger we have to convert
             * the value to integer first
             */
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Seperator);
            Console.WriteLine($"The username is {username} and age is {age}");
        }
    }
}

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Abdul Rafay";
            string LastName = "Modi";
            int FirstInteger = 23;

            //to print a simple name
            Console.WriteLine($"My firstname is {FirstName} and my lastname is {LastName}");

            //We can also write 
            Console.WriteLine("My firstname is " + FirstName + " and my last name is " + LastName);

            //To print a simple integer we can do
            Console.WriteLine(FirstInteger);

            //To find the length of a string we can simply use .Length property
            Console.WriteLine($"The length of firstname is {FirstName.Length}");
        }
    }
}

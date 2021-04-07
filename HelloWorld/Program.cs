using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            string FirstName = "Abdul Rafay";
            string LastName = "Modi";
            int FirstInteger = 23;

            //to print a simple name
            Console.WriteLine($"My firstname is {FirstName} and my lastname is {LastName} \n");
            Console.WriteLine("---------------------------------------------------------------------");

            //We can also write 
            Console.WriteLine("My firstname is " + FirstName + " and my last name is " + LastName + "\n");
            Console.WriteLine("---------------------------------------------------------------------");

            //To print a simple integer we can do
            Console.WriteLine("The first integer is " + FirstInteger.ToString() + "\n");
            Console.WriteLine("---------------------------------------------------------------------");

            //To find the length of a string we can simply use .Length property
            Console.WriteLine($"The length of firstname is {FirstName.Length} \n");
            Console.WriteLine("---------------------------------------------------------------------");

            //To get the upper or lower case we can use 
            Console.WriteLine($"The uppercase of firstname is {FirstName.ToUpper()} or lower case of firstname is {FirstName.ToLower()} \n");
            Console.WriteLine("---------------------------------------------------------------------");

            //find a word in a string
            string SimpleSentence = "I am working with C# and I am loving it";
            Console.WriteLine(SimpleSentence.Contains("working"));


            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}

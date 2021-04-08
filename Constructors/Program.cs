using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program("Ali");
        }
        /*TODO: The constructor is the method 
         * with the same name as the class. 
         * It works like any other method
         * The difference between a method and a
         * contructor is that the constructor invokes 
         * every time the object of the class is created
         * where as a method is only invoked when called 
         * specifically by the object of the same class.
         * Constructors can be overloaded just like 
         * other parameters
         */

        //? CONSTRUCTOR CANNOT HAVE A RETURN TYPE BUT THEY CAN HAVE PARAMETERS
        public Program(string name)
        {
            Console.WriteLine($"The constructor has been invoked and name is {name}");
        }
    }
}

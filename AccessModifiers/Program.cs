using System;

namespace AccessModifiers
{
    class Program
    {
        private string model = "Mustang";
        static void Main(string[] args)
        {
            Program program = new Program();
            Model model = new Model();
            //! This code throws an error because model attribute is private to Model
            //! Console.WriteLine($"Model name is {model.car}");

        }
        public Program()
        {
            Console.WriteLine("A simple constructor:");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Model of car is " + model);
            Console.WriteLine("---------------------------------------");
        }
    }

    class Model
    {
        private string car = "Ford";
    }
}

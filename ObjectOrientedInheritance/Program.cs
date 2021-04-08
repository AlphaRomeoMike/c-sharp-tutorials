using System;

namespace ObjectOrientedInheritance
{
    //TODO: IF we dont want other classes to inherit from base class of vehicle, we can use the "sealed" keyword
    class Vehicle {
        //! Brand is an attribute/property
        //! popHonk() is a method that any vehicle can make
        public string Brand = "Ford";
        public void popHonk()
        {
            Console.WriteLine("Beep boop mofo");
        }
    }

    class Car:Vehicle
    {
        //! This is a specific class for Car that has brand name Mustang
        public string ModelName = "Impala";
        public string Color = "Red & White";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car Mustang = new Car();
            Mustang.popHonk();
            Console.WriteLine($"Mustang's maker is {Mustang.Brand} and it\' brand is {Mustang.ModelName}, it's color is {Mustang.Color}");
        }
    }
}

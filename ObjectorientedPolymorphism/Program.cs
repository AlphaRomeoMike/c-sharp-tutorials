using System;

namespace ObjectorientedPolymorphism
{
    /*! Polymorphism means one name but many forms, 
    * contains of two words namely Poly - meaning 
    * "Many" and morph - meaning "Forms" 
    * This is example of method overloading
    */

    public class Car
    {
        public string model;
        public string color;
        public int year;
    }

    class Program
    {
        public static int Sum(int x, int y)
        {
            int z = x + y;
            return z;
        }

        public static int Sum(int a, int b, int c)
        {
            int d = a + b + c;
            return d;
        }
        static void Main()
        {
            int numA = Sum(5, 6);
            Console.Write("The first function with two parameters: ");
            Console.Write(numA);
            Console.WriteLine();
            int numB = Sum(9, 8, 7);
            Console.Write("The first function with three parameters: ");
            Console.WriteLine(numB);

            Car Ford = new Car
            {
                model = "Ford",
                color = "Red",
                year = 2007
            };

            Console.WriteLine("=============================================");
            Console.WriteLine($"{Ford.model}, {Ford.color}, {Ford.year}");
        }
    }
}

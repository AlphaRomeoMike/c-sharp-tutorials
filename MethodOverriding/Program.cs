using System;

namespace MethodOverriding
{

    class Program
    {
        static void Main(string[] args)
        {
            //! Instantiating objects from both classes here in Class Program
            Exp exp = new Exp();
            Algo algo = new Algo();
            algo.showMessage(); //? This returns "We are in base class"
            exp.showMessage();  //? This returns "Overridden method in child class"
        }
    }
    //! Child/Derived class named Algo
    class Algo : Exp
    {
        new public void showMessage()
        {
            /*!
               * The base keyword can be used to call the method from base class
               */
            Console.WriteLine("==================================");
            Console.WriteLine("Overridden method in child class");
            Console.WriteLine("==================================");
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("This is being executed from the derived class but method is called from base class");
            base.showMessage();
            Console.WriteLine("-----------------------------------------------------------------------------");

        }

    }
    //! Base class named Exp

    class Exp
    {
        public void showMessage()
        {
            Console.WriteLine("We are in base class");
        }
    }
}

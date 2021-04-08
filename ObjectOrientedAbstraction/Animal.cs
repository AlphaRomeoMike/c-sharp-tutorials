using System;

namespace ObjectOrientedAbstraction
{
    public abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
        public static void Main()
        {
            Dog dog = new Dog();
            dog.animalSound();
        }
        /*! At this point if we create an object of this class, 
         * it will throw an error 
         * The reason for this error is because this class is an 
         * abstract class. Interfaces and Abstract classes cannot 
         * have an object. To create an object, this class must be 
         * inherited by another class
         */
    }

    public class Dog : Animal
        /*! At this point, we will have an error because we have 
         * not yet implemented the method of animalSound. As soon
         * as we do that, the error disappears
         */
    {
        public override void animalSound()
        {
            Console.WriteLine("Animal says bow bow");
            sleep();
        }
    }
}

using System;

namespace User_Defined_Exception
{
    class LessThanZeroException : Exception
    {
        public LessThanZeroException(string message) :base(message)
        {
              
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = -10;
            try
            {
                if (a > 0)
                {
                    Console.WriteLine("Valid Data");
                }
                else
                {
                    throw new LessThanZeroException("You tried to divide by Zero");
                }
            }
            catch (LessThanZeroException e)
            {

                Console.WriteLine(e.Message);
            }
        }
    }
}

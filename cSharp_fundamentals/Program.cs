using System;

namespace cSharp_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //Casting
           
            double pi = 3.14;
            int intpi = (int)pi;

            double num1 = 15;
            double num2 = 10.5;

            //Floor
            Console.WriteLine(Math.Floor(num2));

            //Same as Max, Min, Round, Sqrt, Pow, Ceiling, Abs,

            //Random number
            Random rand = new Random();
            Console.WriteLine("Random number between 1 - 10");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(rand.Next(1, 11));
            }

        }
    }
}

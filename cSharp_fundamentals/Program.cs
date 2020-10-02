using System;

namespace cSharp_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}

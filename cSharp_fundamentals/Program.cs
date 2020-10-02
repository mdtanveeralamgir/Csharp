using System;

namespace cSharp_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach
            string randomS = "This is a beautiful day!";
            foreach(char c in randomS)
            {
                Console.WriteLine(c);
            }

        }
    }
}

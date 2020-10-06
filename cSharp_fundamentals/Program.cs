using System;
using System.Collections.Generic;
using System.Text;


namespace cSharp_fundamentals
{
    class Program
    {

        static void Main(string[] arg)
        {
            //Polymorphysm
            Shape tri = new Triangle(3, 4);
            Shape tri2 = new Triangle(4, 4);
            Console.WriteLine(tri.area());

            //Triangle tri3 = tri + tri2;
            Triangle tri3 = new Triangle(3, 3) + new Triangle(4, 4);
            Console.WriteLine(tri3.area());
        }
    }
}

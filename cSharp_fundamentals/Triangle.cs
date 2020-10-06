using System;
namespace cSharp_fundamentals
{
     class Triangle : Shape
    {
        private double length;
        private double width;
        
        public Triangle(double len, double wid)
        {
            this.length = len;
            this.width = wid;
        }

        public override double area()
        {
            return .5 * (length * width);
        }

        //Operator overloading
        public static Triangle operator +(Triangle tri1, Triangle tri2)
        {
            return new Triangle(tri1.length + tri2.length, tri1.width + tri2.width);
        }
        

     }

}

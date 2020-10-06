using System;
using System.Collections.Generic;
using System.Text;


namespace cSharp_fundamentals
{
    
    class Program
    {
        public enum Grades { F = 0, D = 1, C = 2, B = 3, A = 4 }

        static void Main(string[] arg)
        {
            Grades myGrade = Grades.A;
            Console.WriteLine(myGrade);
           
        }
    }
}

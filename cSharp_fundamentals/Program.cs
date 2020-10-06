using System;
using System.Collections.Generic;
using System.Text;


namespace cSharp_fundamentals
{
    //Delegating. passing a method to a function.
    delegate double GetSum(double num1, double num2);
    
    class Program
    {
        

        static void Main(string[] arg)
        {
            //Lambda functions
            //func<param1, param2, returnt type>
            Func<int, int, bool> isEqual = (x, y) => x > y;

            Console.WriteLine(isEqual(10, 9));
           
        }
    }
}

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
            //Annonomus function
            //here GetSum is the data type where the return type is determined by the return of the function
            GetSum sum = delegate (double num1, double num2)
            {
                return num1 + num2;
            };

            Console.WriteLine(sum(5,20));
           
        }
    }
}

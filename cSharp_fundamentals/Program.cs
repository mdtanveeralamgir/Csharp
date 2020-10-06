using System;
using System.Collections.Generic;
using System.Linq;
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

            Console.WriteLine(isEqual.Invoke(10, 9));

            //Appling lambda on a list
            List<int> fullList = new List<int> { 1, 2, 3, 3, 4, 5, 6, 7, 8, 9 };

            //Filtering out the odd numbers and store it in a new list
            List<int> oddList = fullList.Where(n=>n%2!=0).ToList();

            foreach(int value in oddList)
            {
                Console.WriteLine(value);
            }

        }
    }
}

using System;

namespace cSharp_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //write on console
            Console.Write("What's your name?"); //No new line
            string name = Console.ReadLine(); //read from console
            Console.WriteLine("Hello " + name); //With new line
            */

            //**********************************************************

            //Premative types and values

            //Integer
            int maxInt = int.MaxValue;
            Console.WriteLine(maxInt); //2147483647

            long maxLong = long.MaxValue;
            Console.WriteLine(maxLong); //9223372036854775807

            //Decimal
            decimal maxDeci = decimal.MaxValue;
            Console.WriteLine(maxDeci); //79228162514264337593543950335

            //Float
            float maxFloat = float.MaxValue;
            Console.WriteLine(maxFloat); //3.4028235E+38

            //Double
            double maxDouble = double.MaxValue;
            Console.WriteLine(maxDouble); //1.7976931348623157E+308

            //Variable on the fly. similar to auto in c++
            var cPlusPlusAuto = "Tanveer";
            Console.WriteLine(cPlusPlusAuto);
            //cPlusPlusAuto = 2; //Error

            //Get the type of a data
            Console.WriteLine("cPlusPlusAuto is a {0}", cPlusPlusAuto.GetTypeCode());



        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;


namespace cSharp_fundamentals
{
    class Program
    {
        //Exception

        static void Main(string[] arg)
        {
            int x = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("{0}/{1} = {2}", 10, x, 10 / x);
                    
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.GetType().Name);//Name of the error type
                Console.WriteLine(ex.Message);
                //throw ex; //Throw the current exception
                //throw new InvalidCastException("Operation failed"); //throw new exception with a message

            }
            catch (Exception ex) //Default catch block
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

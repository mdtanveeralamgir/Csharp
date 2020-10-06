using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace cSharp_fundamentals
{
    
    
    class Program
    {
        

        static void Main(string[] arg)
        {
            //string ranString;
            //IO
            string[] custs = new string[] { "Tom", "dick", "Harry" };
            using (StreamReader sr = new StreamReader("/Users/Opel/Desktop/text.txt"))
            {
                while (!sr.EndOfStream) 
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            using(StreamWriter sw = new StreamWriter("/Users/Opel/Desktop/text.txt", append:true))
            {
                foreach(string c in custs)
                {
                    sw.WriteLine(c);
                }
            }

        }
    }
}

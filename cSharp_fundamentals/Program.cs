using System;
using System.Text;

namespace cSharp_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            //String builder
            StringBuilder sb = new StringBuilder();
            sb.Append("This is the first sentense.");
            sb.AppendFormat("My Name is {0} and I live in {1}", "Opel", "Canada");
            sb.Replace("a", "e");
            Console.WriteLine(sb.ToString());

        }
    }
}

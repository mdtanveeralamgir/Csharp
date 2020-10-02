using System;

namespace cSharp_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            //String

            string backSlash = "hello \" "; // \" will make " a string

            Console.WriteLine(backSlash);

            Console.WriteLine("Is Null or empty " + String.IsNullOrEmpty(backSlash));
            Console.WriteLine("Is Null or white space " + String.IsNullOrWhiteSpace(backSlash));
            Console.WriteLine("String length " + backSlash.Length);

            //Substring

            string str = "This is a random string";

            int index = str.IndexOf("random"); //Gives the index of starting random

            Console.WriteLine("Getting the substring " + str.Substring(index, 6));

            //Comparing 2 strings

            Console.WriteLine("Compare backSlash and str " + str.Equals(backSlash));

            //Starts with
            Console.WriteLine("Is starts with " + str.StartsWith("This")); //Case sensitive. Same as str.EndsWith

            //Trim

            str.Trim(); //Trim white spaces from both ends. TrimEnd, TrimStart are available

            //Replace words
            string sampleString = str.Replace("string", "line");
            Console.WriteLine(sampleString);

            //Remove characters
            sampleString = str.Remove(0, 2); //Starting from 0. removing 2 characters

            Console.WriteLine(sampleString);

            //Array of string and join them
            string[] names = new string[2] { "Aayid", "Alamgir" };
            Console.WriteLine("Joining Array of string " + String.Join(' ', names));

            //Formating string
            /*
             * {0:c} = currency
             * {1:00.00} = 2 decimal places before and after .
             * {2:#.00} = # = can be 0 or not before "." but 2 decimal places after .
             * {3:0,0} = 1000 = 1,000
             */
            string strFormatted = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.45, 15.456, .345, 1000);
            Console.WriteLine(strFormatted);


        }
    }
}

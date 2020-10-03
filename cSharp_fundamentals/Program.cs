using System;
using System.Collections.Generic;
using System.Text;


namespace cSharp_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            //List

            List<int> list = new List<int>();
            list.Add(2);

            //Add array into list
            int[] numArray = { 1, 2, 3, 4 };
            list.AddRange(numArray);

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}

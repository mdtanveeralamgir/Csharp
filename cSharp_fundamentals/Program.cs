using System;
using System.Text;

namespace cSharp_fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array
            int[] randNumArray;
            int[] randArray = new int[5];
            int[] randomArray = { 1, 2, 3, 4, 5 };
            foreach(var value  in randomArray)
            {
                //Console.WriteLine(value);
            }

            //Console.WriteLine(Array.IndexOf(randomArray, 1));

            //multidimantional array
            int[,] multiArray = new int[5, 3];
            int[,] multiArray2 = { { 0, 1 }, { 2, 1 }, { 3, 2 } };

            foreach(var value in multiArray2)
            {
                //Console.WriteLine(value);
            }

            for(int x = 0; x < multiArray2.GetLength(0); x++)
            {
                for(int y = 0; y< multiArray2.GetLength(1); y++)
                {
                    Console.WriteLine("{0} | {1} : {2}", x, y, multiArray2[x,y]);
                }
            }
        }
    }
}

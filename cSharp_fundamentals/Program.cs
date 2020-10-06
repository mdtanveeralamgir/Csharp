using System;
using System.Collections.Generic;
using System.Text;


namespace cSharp_fundamentals
{
    class Program
    {

        static void Main(string[] arg)
        {
            KeyValue<int, double> kv = new KeyValue<int, double>(4, 5.6);
            kv.showDataType();
        }
    }
}

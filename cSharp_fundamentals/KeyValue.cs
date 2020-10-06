using System;
namespace cSharp_fundamentals
{
    //Generics
    class KeyValue<TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }
        public KeyValue(TKey k, TValue v)
        {
            this.key = k;
            this.value = v;
        }

        public void showDataType()
        {
            Console.WriteLine("{0} this is key and {1} this is value", this.key, this.value);
        }
    }
}

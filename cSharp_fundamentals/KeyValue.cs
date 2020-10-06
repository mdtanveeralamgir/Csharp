using System;
namespace cSharp_fundamentals
{
    //Generics
    class KeyValue<TKey, TValue>
    {
        public TKey key { get; set; }
        public TValue value { get; set; }
        public KeyValue()
        {
        }
    }
}

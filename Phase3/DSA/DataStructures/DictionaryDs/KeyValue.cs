using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryDs
{
    public class KeyValue<Tkey, TValue>
    {
        public Tkey Key { get; set; }
        public TValue Value { get; set; }
    }
}
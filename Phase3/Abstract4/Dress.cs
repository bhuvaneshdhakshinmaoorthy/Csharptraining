using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract4
{
    public enum DressType{Default,LadiesWear,MensWear,ChildrensWear}
    public abstract class Dress
    {
        public abstract DressType DressType { get; set; }
        public abstract string DressName { get; set; }
        public abstract double Price { get; set; }
        public abstract double TotalPrice { get; set; }
        public abstract string GetDressInfo();
        public abstract double DisplayInfo();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract4
{
    public class MensWear : Dress
    {
        public override DressType DressType { get; set; }
        public override string DressName { get; set; }
        public override double Price { get; set; }
        public override double TotalPrice { get; set; }
        public MensWear(DressType dressType, string dressName, double price)
        {
            DressType = dressType;
            DressName = dressName;
            Price = price;
        }
        public override string GetDressInfo()
        {
            return "j";
        }
        public override double DisplayInfo()
        {
            return TotalPrice = Price - (Price * 30/100);
        }
    }
}
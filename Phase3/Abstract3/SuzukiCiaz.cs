using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract3
{
    public class SuzukiCiaz : Car
    {
        public SuzukiCiaz(EngineType engineType, int noOfSeats, double price, CarType carType)
        {
            EngineType = engineType;
            NoOfSeats = noOfSeats;
            Price = price;
            CarType = carType;
        }
        public override EngineType GetEngineType()
        {
            return EngineType;
        }
        public override int GetNoOfSeats()
        {
            return NoOfSeats;
        }
        public override double GetPrice()
        {
            return Price;
        }
        public override CarType GetCarType()
        {
            return CarType;
        }
        public override string GetCarDetails()
        {
            return $"{EngineType} {NoOfSeats} {Price} {CarType}";
        }
    }
}
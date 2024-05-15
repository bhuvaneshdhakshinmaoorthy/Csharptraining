using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract3
{
    public enum EngineType{Default,Petrol,Diesel,CNG}
    public enum CarType{Dafault,Hatchback,Sedan,SUV}
    public abstract class Car
    {
        private int _noOfWheels = 4;
        private int _noOfDoors = 4;
        public string NoOfWheels { get; set; }
        public string NoOfDoors { get; set; }
        public EngineType EngineType { get; set; }
        public int NoOfSeats { get; set; }
        public double Price { get; set; }
        public CarType CarType { get; set; }
        public int ShowWheels()
        {
            return _noOfWheels;
        }
        public int ShowDoors()
        {
            return _noOfDoors;
        }
        public abstract EngineType GetEngineType();
        public abstract int GetNoOfSeats();
        public abstract double GetPrice();
        public abstract CarType GetCarType();
        public abstract string GetCarDetails();
    }
}
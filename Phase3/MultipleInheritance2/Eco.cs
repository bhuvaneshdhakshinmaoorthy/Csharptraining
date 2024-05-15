using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleInheritance2
{
    public class Eco : Car, IBrand
    {
        private int _makingID = 2000;
        public string MakingID { get; set; }
        public int EngineNumber { get; set; }
        public int ChasisNumber { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public Eco(string fuelType, int numberOfSeats, string color, double tankCapacity, double numberOfKmDriven, int engineNumber, int chasisNumber, string brandName, string modelName) : base(fuelType, numberOfSeats, color, tankCapacity, numberOfKmDriven)
        {
            _makingID++;
            MakingID = "MID" + _makingID;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
            BrandName = brandName;
            ModelName = modelName;
        }
        

        public string ShowDetails()
        {
            return $"{BrandName} {ModelName} {MakingID} {EngineNumber} {ChasisNumber} {FuelType} {NumberOfSeats} {Color} {TankCapacity} {NumberOfKmDriven}" ;
        }
    }
}
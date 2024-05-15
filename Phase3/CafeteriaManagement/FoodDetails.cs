using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class FoodDetails
    {
        private static int s_foodID = 100;
        public string FoodID { get; }
        public string FoodName { get; set; }
        public double FoodPrice { get; set; }
        public int AvailableQuantity { get; set; }

        public FoodDetails(string foodName, double foodPrice, int availableQuantity)
        {
            s_foodID++;
            FoodID = "FID" + s_foodID;
            FoodName = foodName;
            FoodPrice = foodPrice;
            AvailableQuantity = availableQuantity;
        }

        public FoodDetails(string food)
        {
            string[] value = food.Split(",");
            s_foodID = int.Parse(value[0].Remove(0,3));
            FoodID = value[0];
            FoodName = value[1];
            FoodPrice = double.Parse(value[2]);
            AvailableQuantity = int.Parse(value[3]);
        }
    }
}
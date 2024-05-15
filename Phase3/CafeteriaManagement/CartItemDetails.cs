using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class CartItemDetails
    {
        private static int s_itemID = 100;
        private static int s_orderID = 100;
        public string ItemID { get; set; }
        public string OrderID { get; set; }
        public string FoodID { get; set; }
        public double OrderPrice { get; set; }
        public int OrderQuantity { get; set; }

        public CartItemDetails(string orderID, string foodID, double orderPrice, int orderQuantity)
        {
            s_itemID++;
            ItemID = "ITID" + s_itemID;
            s_orderID++;
            OrderID = "OID" + s_orderID;
            OrderID = orderID;
            FoodID = foodID;
            OrderPrice = orderPrice;
            OrderQuantity = orderQuantity;
        }

        public CartItemDetails(string cart)
        {
            string[] value = cart.Split(",");
            s_itemID = int.Parse(value[0].Remove(0,4));
            ItemID = value[0];
            OrderID = value[1];
            FoodID = value[2];
            OrderPrice = double.Parse(value[3]);
            OrderQuantity = int.Parse(value[4]);
        }
    }
}
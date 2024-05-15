using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public enum OrderStatus{Default,Initiated,Ordered,Cancelled}
    public class OrderDetails
    {
        private static int s_orderID = 1000;
        public string OrderID { get; }
        public string UserID { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public OrderDetails(string userID, DateTime orderDate, double totalPrice, OrderStatus orderStatus)
        {
            s_orderID++;
            OrderID = "OID" + s_orderID;
            UserID = userID;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
            OrderStatus = orderStatus;
        }

        public OrderDetails(string order)
        {
            string[] value = order.Split(",");
            s_orderID = int.Parse(value[0].Remove(0,3));
            OrderID = value[0];
            UserID = value[1];
            OrderDate = DateTime.Parse(value[2]);
            TotalPrice = double.Parse(value[3]);
            OrderStatus = Enum.Parse<OrderStatus>(value[4]);
        }
    }
}
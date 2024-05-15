using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class TravelHistory
    {
        private static int s_travelID = 2000;
        public string TravelID { get; }
        public string CardNumber { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime Date { get; set; }
        public double TravelCost { get; set; }

        public TravelHistory(string cardNumber, string fromLocation, string toLocation, DateTime date, double travelCost)
        {
            s_travelID++;;
            TravelID = "TID" + s_travelID;
            CardNumber = cardNumber;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            Date = date;
            TravelCost = travelCost;
        }
        public TravelHistory(string travel)
        {
            string[] value = travel.Split(",");
            s_travelID = int.Parse(value[0].Remove(0,3));
            TravelID = value[0];
            CardNumber = value[1];
            FromLocation = value[2];
            ToLocation = value[3];
            Date = DateTime.Parse(value[4]);
            TravelCost = double.Parse(value[5]);
        }
    }
}
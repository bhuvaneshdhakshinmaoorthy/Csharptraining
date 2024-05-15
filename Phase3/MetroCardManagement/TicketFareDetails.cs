using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class TicketFareDetails
    {
        private static int s_ticketID = 3000;
        public string TicketID { get; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public double TicketPrice { get; set; }

        public TicketFareDetails(string fromLocation, string toLocation, double ticketPrice)
        {
            s_ticketID++;
            TicketID = "MR" + s_ticketID;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TicketPrice = ticketPrice;
        }
        public TicketFareDetails(string ticket)
        {
            string[] value = ticket.Split(",");
            s_ticketID = int.Parse(value[0].Remove(0,2));
            TicketID = value[0];
            FromLocation = value[1];
            ToLocation = value[2];
            TicketPrice = double.Parse(value[3]);
        }
    }
}
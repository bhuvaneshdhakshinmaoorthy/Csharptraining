using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodBankManagement
{
    public enum BloodGroup{Select,A_Positive,B_Positive,O_Positive,AB_Positive}
    public class DonationDetails
    {
        private static int s_donoationID = 1000;
        public string DonationID { get; }
        public string DonorID { get; set; }
        public DateTime DonationDate { get; set; }
        public double Weight { get; set; }
        public double BloodPressure { get; set; }
        public double HemoglobinCount { get; set; }
        public BloodGroup BloodGroup { get; set; }

        public DonationDetails(string donorID,DateTime donationDate,double weight,double bloodPressure,double hemoglobinCount,BloodGroup bloodGroup)
        {
            s_donoationID++;
            DonationID = "DID" + s_donoationID;
            DonorID = donorID;
            DonationDate = donationDate;
            Weight = weight;
            BloodPressure = bloodPressure;
            HemoglobinCount = hemoglobinCount;
            BloodGroup = bloodGroup;
        }
    }
}
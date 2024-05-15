using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBBillCalculation1
{
    public class UserRegistration
    {
        private static int s_meterID = 1000;
        public string MeterID { get; }
        public string UserName { get; set; }
        public long PhoneNumber { get; set; }
        public string MailID { get; set; }
        public double UnitsUsed { get; set; }

        public UserRegistration(string userName, long phoneNumber, string mailID, double unitsUsed)
        {
            s_meterID++;
            MeterID = "EB" + s_meterID;
            UserName = userName;
            PhoneNumber = phoneNumber;
            MailID = mailID;
            UnitsUsed = unitsUsed;
        }
        public double CalculateAmountMethod()
        {
            return(UnitsUsed * 5);
        }
    }
}
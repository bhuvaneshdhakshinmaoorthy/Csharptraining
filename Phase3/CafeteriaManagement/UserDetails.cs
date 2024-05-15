using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class UserDetails : PersonalDetails, IBalance
    {
        private static int s_userID = 1000;
        public string UserID { get; }
        public string WorkStationNumber { get; set; }
        private static double s_balance;

        public UserDetails(string name, string fatherName,long mobileNumber, string mailID, Gender gender, string workStationNumber, double balance) : base(name, fatherName, mobileNumber, mailID, gender)
        {
            s_userID++;
            UserID = "SF" + s_userID;
            WorkStationNumber = workStationNumber;
            s_balance = balance;
        }

        public double WalletBalance { get{return s_balance;}  }

        public void  WalletRechargeMethod(double amount)
        {
             s_balance += amount;
        }
        public void DeductAmountMethod(double amount)
        {
            if(amount>0)
            {
                s_balance -= amount;
            }
        }

        public void ReturnMethod(double amount)
        {
            if(amount>0)
            {
                s_balance += amount;
            }
        }
        
        public UserDetails(string user): base(user)
        {
            string[] value = user.Split(",");
            UserID = value[0];
            s_userID = int.Parse(value[0].Remove(0,2));
            Name = value[1];
            FatherName = value[2];
            MobileNumber = long.Parse(value[3]);
            MailID = value[4];
            Gender = Enum.Parse<Gender>(value[5]);
            WorkStationNumber = value[6];
            s_balance = double.Parse(value[7]);
        }
    }
}
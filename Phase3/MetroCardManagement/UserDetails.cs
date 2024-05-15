using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class UserDetails : PersonalDetails, IBalance
    {
        private static int s_cardNumber = 1000;
        public string CardNumber { get; }
        public double Balance { get; set; }
        public UserDetails( string userName, long phoneNumber, double balance): base (userName,  phoneNumber)
        {
            s_cardNumber++;
            CardNumber = "CMRL" + s_cardNumber;
            Balance =  balance;
        }

        public void WalletRecharge(double amount)
        {
            if(amount>0)
            {
                Balance = Balance + amount;
            }
        }

        public void DeductBalance(double amount)
        {
            if(amount>0)
            {
                Balance = Balance - amount;
            }
        }
        public UserDetails(string user) : base(user)
        {
            string[] value = user.Split(",");
            s_cardNumber = int.Parse(value[0].Remove(0,4));
            CardNumber = value[0];
            UserName = value[1];
            PhoneNumber = long.Parse(value[2]);
            Balance = double.Parse(value[3]);
        }
    }
}
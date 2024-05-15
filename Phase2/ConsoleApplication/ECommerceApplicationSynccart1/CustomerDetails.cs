using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerceApplicationSynccart
{
    public class CustomerDetails
    {
        private static int s_customerID = 3000;
        public String CustomerID { get; }
        public string CustomerName { get; set; }
        public string City { get; set; }
        public long Phone { get; set; }
        public double WalletBalance { get; set; }
        public string MailID { get; set; }

        public CustomerDetails(string customerName,string city, long phone,double walletBalance,string mailID)
        {
            s_customerID++;
            CustomerID = "CID" + s_customerID;
            CustomerName = customerName;
            City = city;
            Phone = phone;
            WalletBalance = walletBalance;
            MailID = mailID;
        }

        public double ForRecharge(double rechargeAmount)
        {
            return WalletBalance += rechargeAmount;
        }
        public double DeductBalanceMethod(double deductbalance)
        {
            return WalletBalance -= deductbalance;
        }
    }
}
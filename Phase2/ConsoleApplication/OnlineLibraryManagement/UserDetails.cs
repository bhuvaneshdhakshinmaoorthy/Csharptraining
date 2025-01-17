using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryManagement
{
    public enum Gender{Select,Male,Female,Others}
    public enum Department{Select,ECE,EEE,CSE}
    public class UserDetails
    {
        private static int s_userID = 3000;
        public string UserID { get; }
        public string UserName { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; }
        public long MobileNumber { get; set; }
        public string MailID { get; set; }
        public double WalletBalance { get; set; }

        public UserDetails(string userName,Gender gender,Department department,long mobileNumber,string mailID,double walletBalance)
        {
            s_userID++;
            UserID = "SF" + s_userID;
            UserName = userName;
            Gender = gender;
            Department = department;
            MobileNumber = mobileNumber;
            MailID = mailID;
            WalletBalance = walletBalance;
        }
        public double WalletRechargeMethod(double rechargeAmount)
        {
            return WalletBalance += rechargeAmount;
        }
        public double DeductBalanceMethod(double deductAmount)
        {
            return WalletBalance += deductAmount;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAccountOpening1
{
    public enum Gender{Select,Male,Female,Others}
    public class BankPortal
    {
        private static int s_customerID = 1000;
        public string CustomerID { get; }
        public string CustomerName { get; set; }
        public double Balance { get; set; }
        public Gender Gender { get; set; }
        public long Phone { get; set; }
        public string MailID { get; set; }
        public DateTime DateOfBirth { get; set; }

        public BankPortal(string customerName, double balance,Gender gender,long phone,string mailID,DateTime dob)
        {
            s_customerID++;
            CustomerID = "HDFC" + s_customerID;
            CustomerName = customerName;
            Balance = balance;
            Gender = gender;
            Phone = phone;
            MailID = mailID;
            DateOfBirth = dob;
        }
        public double DepositMethod(double depositAmount)
        {
            return Balance += depositAmount;
        }
        public bool Withdrawn(double withdrawnAmount)
        {
            if(withdrawnAmount<=Balance)
            {
                Balance -= withdrawnAmount;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
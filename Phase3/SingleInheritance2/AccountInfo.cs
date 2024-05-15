using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance2
{
    public class AccountInfo : PersonalInfo
    {
        public long AccountNumber { get; set; }
        public string BranchName { get; set; }
        public string IFSC { get; set; }
        public double Balance { get; set; }
        public AccountInfo(string name, string fatherName, long phone, string mail, DateTime dob, string gender, long accountNumber, string branchName, string ifsc, double balance) : base(name, fatherName, phone, mail, dob, gender)
        {
            AccountNumber = accountNumber;
            BranchName = branchName;
            IFSC = ifsc;
            Balance = balance;
        }
        public string ShowAccountInfo()
        {
            return ($"{Name} {FatherName} {Phone} {Mail} {DOB} {Gender} {AccountNumber} {BranchName} {IFSC} {Balance}");
        }
        public double Deposit(double amount)
        {
            return Balance += amount;
        }
        public double WithDraw(double amount)
        {
            return Balance -= amount;
        }
        public double ShowBalance()
        {
            return Balance;
        }
    }
}
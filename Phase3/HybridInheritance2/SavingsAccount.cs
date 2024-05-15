using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritance2
{
    public enum AccountType{Default,SavingsAccount, BalanceAccount}
    public class SavingsAccount : IDInfo, ICalculate, IBankInfo
    {
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string Branch { get; set; }
        public long AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public double Balance { get; set; }
        public SavingsAccount(string name, string gender, DateTime dob, long phone, string voterID, string aadharID, string pan, long accountNumber, AccountType accountType) : base(name, gender, dob, phone, voterID, aadharID, pan)
        {
            AccountNumber = accountNumber ;
            AccountType = accountType;
        }

        public double Deposit(double amount)
        {
            
            return Balance += amount;
        }

        public double Withdraw(double amount)
        {
            return Balance -= amount;
        }

        public double BalanceMethod()
        {
            return Balance;
        }
    }
}
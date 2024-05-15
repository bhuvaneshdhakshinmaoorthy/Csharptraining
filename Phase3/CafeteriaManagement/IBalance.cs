using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public interface IBalance
    {
        public double WalletBalance { get; }
        void WalletRechargeMethod(double amount);
        void DeductAmountMethod(double amount);
    }
}

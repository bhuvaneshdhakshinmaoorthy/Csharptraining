using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial
{
    public class StudentMethod
    {
        public partial class StudentDetails
        {
            public void GetBalance(int amount)
            {
                _balance = amount;
            }
            public double ShowBalance()
            {
                return _balance;
            } 
        }
    }
}
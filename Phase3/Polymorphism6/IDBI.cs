using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism6
{
    public class IDBI : Bank
    {
        public override double GetInterestInfo()
        {
            return 7.5;
        }
    }
}
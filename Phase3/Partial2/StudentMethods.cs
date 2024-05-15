using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial2
{
    public partial class StudentInfo
    {
        public double Calculate()
        {
            return Physics + Chemistry + Maths;
        }
        public double Percentage()
        {
            return Calculate()/300 * 100;
        }
    }
}
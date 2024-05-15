using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed4
{
    public class CircleCalculator : Calculator
    {
        public double R { get; set; }
        public sealed override void Area()
        {
            double area = 3.14 * R * R;
        }

        public override void Volume()
        {
            
        }
    }
}
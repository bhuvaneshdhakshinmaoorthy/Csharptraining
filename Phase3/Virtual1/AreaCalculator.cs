using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtual1
{
    public class AreaCalculator
    {
        public double Radius { get; set; }
        public AreaCalculator(double radius)
        {
            Radius = radius;
        }
        public virtual double Calculate()
        {
            return Math.PI * Radius * Radius;
        }
        public virtual double Display()
        {
            return Calculate();
        }
    }
}
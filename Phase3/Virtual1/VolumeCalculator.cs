using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtual1
{
    public class VolumeCalculator : AreaCalculator
    {
        public double Height { get; set; }
        public VolumeCalculator(double radius,double height) : base(radius)
        {
            Height = height;
        }

        public override double Calculate()
        {
            return Math.PI * Radius * Radius * Height;
        }
        public override double Display()
        {
            return Calculate();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract1
{
    public abstract class Shape
    {
        public abstract double Area { get; set; }
        public abstract double Volume { get; set; }
        public abstract double CalculateArea();
        public abstract double CalculateVolume();

    }
}
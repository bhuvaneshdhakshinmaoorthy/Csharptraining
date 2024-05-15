using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract1
{
    public class Cylinders : Shape
    {
        public override double Area { get; set; }
        public override double Volume { get; set; }
         public double Radius { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public Cylinders(double radius, double height, double width) 
        {
            Radius = radius ;
            Height = height;
            Width = width;
        }
        public override double CalculateArea()
        {
            Area = 2 * Math.PI * Radius * (Radius + Height);
            return Area;
        }
        public override double CalculateVolume()
        {
            Volume = Math.PI * Radius * 2 * Height;
            return Volume;
        }
    }
}
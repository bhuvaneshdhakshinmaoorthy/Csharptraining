using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea : Maths
    {
        protected double _radius;
        public double Radius { get {return _radius;} }
        internal double Area { get; set; }
        public CircleArea(double radius)
        {
            _radius = radius;
        }
        public double CalculateCircleArea()
        {
            Area = PAI * (_radius * _radius);
            return Area;
        }
    }
}
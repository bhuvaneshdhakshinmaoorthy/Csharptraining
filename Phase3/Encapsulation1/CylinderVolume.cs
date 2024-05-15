using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorApp;

namespace Encapsulation1
{
    public class CylinderVolume : CircleArea
    {
        private double _height;
        public double Height { get{return _height;}}
        internal double Volume { get; set; }

        public CylinderVolume(double radius, double height) : base(radius)
        {
            _height = height;
        }
        public double CalculateVolume()
        {
            Volume = CalculateCircleArea() * Height;
            return  Volume; 
        }
    }
}
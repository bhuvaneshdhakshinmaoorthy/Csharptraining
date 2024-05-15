using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathsLib
{
    public class Maths
    {
        protected internal double _pi = 3.14;
        internal double _g = 9.8;
        public  double PAI { get { return _pi;} }
        public  double Gravity { get { return _g;} }
        public Maths()
        {
            
        }
        public double CalculateWeight(double mass)
        {
            double Mass = mass;
            double ans = Mass * Gravity;
            return ans;
        }
    }
}
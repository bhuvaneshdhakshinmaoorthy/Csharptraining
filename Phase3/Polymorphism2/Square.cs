using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism2
{
    public class Square
    {
        public int Squares(int a)
        {
            return a*a;
        }
        public float Squares(float a)
        {
            return a*a;
        }
        public double Squares(double a)
        {
            return a*a;
        }
        public long Squares(long a)
        {
            return a*a;
        }
    }
}
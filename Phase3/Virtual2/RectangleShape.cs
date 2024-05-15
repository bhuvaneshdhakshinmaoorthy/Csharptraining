using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtual2
{
    public class RectangleShape : Dimention
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public RectangleShape(double value1, double value2) : base( value1,  value2 )
        {
            Length = value1;
            Height = value2;
        }
        public override double Calculate()
        {
            return Area = Length * Height;
        }
        public override double DisplayArea()
        {
            return Calculate();
        }
    }
}
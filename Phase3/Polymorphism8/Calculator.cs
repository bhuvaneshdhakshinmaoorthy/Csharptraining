using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism8
{
    public class Calculator
    {
        public int Paper1 { get; set; }
        public int Paper2 { get; set; }
        public int Paper3 { get; set; }
        public int Paper4 { get; set; }
        public int Paper5 { get; set; }
        public int Paper6 { get; set; }
        public Calculator()
        {
        }
        public double  Calculate(double paper1,  double paper2, double paper3, double paper4, double paper5, double paper6)
        {
            double total1 =  paper1 + paper2 + paper3 + paper4 + paper5 + paper6;
            double percen1 = total1/600 * 100;
            return total1 ;
        }
    
        public double Calculate(double sem1, double sem2, double sem3, double sem4)
        {
            double total2 =  sem1 + sem2 + sem3 +  sem4;
            return total2/2400 * 100;
        }
    }
}
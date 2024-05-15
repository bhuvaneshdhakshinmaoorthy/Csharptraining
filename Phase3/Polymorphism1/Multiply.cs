using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism1
{
    public class Multiply
    {
        public static void Multiply1(double a)
        {
            System.Console.WriteLine(a*a);
        }
        public static void Multiply1(double a,double b)
        {
            System.Console.WriteLine(a*a);
            System.Console.WriteLine(b*b);
        }
        public static void Multiply1(double a,double b,double c)
        {
            System.Console.WriteLine(a*a);
            System.Console.WriteLine(b*b);
            System.Console.WriteLine(c*c);
        }
        public static void Multiply1(int a,double b)
        {
            System.Console.WriteLine(a*a);
            System.Console.WriteLine(b*b);
        }
        public static void Multiply1(int a,double b,float c)
        {
            System.Console.WriteLine(a*a);
            System.Console.WriteLine(b*b);
            System.Console.WriteLine(c*c);
        }
    }
}
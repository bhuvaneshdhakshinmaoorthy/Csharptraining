using System;

namespace Question1
{
    class  Program
    {
        public static void Main(string[] args)
        {
            double INR = double.Parse(Console.ReadLine());

            double USD = 0.012199999999999999;
            double EUR = 0.0127;
            double CNY = 0.08789999999999999;

            double cUSD = INR * USD;
            double cEUR = INR * EUR;
            double cCNY = INR * CNY;
            
            Console.WriteLine($"{Math.Round(cUSD,2)} USD");
            Console.WriteLine($"{Math.Round(cEUR,2)} EUR");
            Console.WriteLine($"{Math.Round(cCNY,2)} CNY");
        }
    }
}
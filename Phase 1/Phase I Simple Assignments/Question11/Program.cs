using System;

namespace Question11
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if( num<=1)
            {
                Console.WriteLine($"{num} is not a prime number");
            }
            else
            {
                if(num%2!=0)
                {
                    Console.WriteLine($"{num} is a prime number");
                }
                else
                {
                    Console.WriteLine($"{num} is not a prime number");
                }
            }
        }
    }
}
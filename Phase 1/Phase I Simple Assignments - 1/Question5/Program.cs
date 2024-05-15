using System;

namespace Question5
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            while(num>0)
            {
                int digit = num%10;
                Console.Write(digit);
                num /= 10;
            }
        }
    }
}
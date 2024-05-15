using System;

namespace Question2
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if(num<0 )
            {
                Console.WriteLine("Error");
            }
            else if(num==0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(num*num);
            }
        }
    }
}
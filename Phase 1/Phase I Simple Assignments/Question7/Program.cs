using System;

namespace Question7
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int mul = 1;
            for( int i=1; i<=y; i++)
            {
                mul *= x;
            }
            Console.WriteLine(mul);
        }
    }
}
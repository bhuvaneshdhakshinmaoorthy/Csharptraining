using System;

namespace Question3
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for( int i = num; i>0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
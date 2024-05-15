using System;

namespace Question10
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            for( int i =1; i<=x; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
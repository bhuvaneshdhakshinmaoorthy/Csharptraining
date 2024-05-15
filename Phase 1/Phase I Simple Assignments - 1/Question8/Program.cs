using System;

namespace Question8
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string value = Console.ReadLine();

            string[] values = value.Split(" ");

            int[] intArray = new int[n];

            for( int i =0; i<n; i++)
            {
                intArray[i] = int.Parse(values[i]);
            }

            foreach( int i in intArray)
            {
                if(i%2==0)
                {
                    Console.Write("even ");
                }
                else
                {
                    Console.Write("odd ");
                }
            }
        }
        
    }
}
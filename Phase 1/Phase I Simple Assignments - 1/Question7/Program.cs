using System;

namespace Question7
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

            int maxi = intArray[0];

    
            for( int i = 1; i<n; i++)
            {
                if(intArray[i] > maxi)
                {
                    maxi = intArray[i];
                }
            }
            Console.WriteLine(maxi);
        }
        
    }
}
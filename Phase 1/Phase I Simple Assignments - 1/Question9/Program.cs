using System;

namespace Question9
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string value = Console.ReadLine();

            string[] values = value.Split(",");

            int[] intArray = new int[n];

            for( int i =0; i<n; i++)
            {
                intArray[i] = int.Parse(values[i]);
            }

            int sum = 0;
            foreach(int i in intArray)
            {
                sum += i;
            }

            if(sum%2==0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
        
    }
}
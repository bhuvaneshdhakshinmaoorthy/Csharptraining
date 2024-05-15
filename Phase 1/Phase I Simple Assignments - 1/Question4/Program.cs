using System;

namespace Question4
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string values = Console.ReadLine();
            int check = int.Parse(Console.ReadLine());

            string[] main = values.Split(", ");
            int[] intArray = new int[num];

            for( int i = 0; i<num; i++)
            {
                intArray[i] = int.Parse(main[i]);
            }

            int count = 0;
            foreach( int i in intArray)
            {
                if(i==check)
                {
                    count++;
                }
            }

            if(count>0)
            {
                Console.WriteLine($"yes {count}");
            }
            else
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
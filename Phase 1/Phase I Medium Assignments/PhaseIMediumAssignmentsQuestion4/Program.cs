using System;

namespace PhaseIMediumAssignmentsQuestion4
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int num  = int.Parse(Console.ReadLine());

            for( int i=1; i<=num;i++)
            {
                int sum = 0;

                int temp = i;

                int digits = 0;

                while(temp>0)
                {
                    temp/=10;
                    digits++;
                }

                temp = i;

                while(temp>0)  
                {   
                    sum += (int)Math.Pow(temp % 10,digits);
                    temp /= 10;
                }
                if(sum == i)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
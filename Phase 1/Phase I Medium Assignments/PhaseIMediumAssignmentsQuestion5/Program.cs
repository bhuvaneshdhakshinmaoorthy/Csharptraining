using System;

namespace PhaseIMediumAssignmentsQuestion5
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int start  = int.Parse(Console.ReadLine());
            int diff  = int.Parse(Console.ReadLine());
            int end  = int.Parse(Console.ReadLine());

            int final = 0;
            for( int i = 1; i<=end; i++)
            {
                final += start;
                start += diff;
            }
            Console.WriteLine(final);
        }
    }
}
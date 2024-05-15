using System;

namespace PhaseIMediumAssignmentsQuestion3
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            for(int i=1; i<num; i++)
            {
                if(i%4==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
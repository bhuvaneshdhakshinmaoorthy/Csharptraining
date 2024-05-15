using System;

namespace PhaseIMediumAssignmentsQuestion6
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int width  = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            for( int i=1; i<=height; i++)
            {
                for(int j=1; j<=width; j++)
                {
                    if( i==1 || j==1 || i==height || j==width)
                    {
                        Console.Write("*");                       
                    }
                    else 
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
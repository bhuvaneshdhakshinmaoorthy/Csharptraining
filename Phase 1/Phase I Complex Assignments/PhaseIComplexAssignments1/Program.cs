using System;

namespace PhaseIComplexAssignments1
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            
            int[,] aMatrix = new int[m,n];
            int[,] bMatrix = new int[n,m];
            int[,] cMatrix = new int[m,m];

            for(int i=0; i<m; i++)
            {
                for( int j=0; j<n; j++)
                {
                    aMatrix[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for(int i=0; i<n; i++)
            {
                for( int j=0; j<m; j++)
                {
                    bMatrix[i,j] = int.Parse(Console.ReadLine());
                }
            }

            for(int i=0; i<m; i++)
            {
                for( int j=0; j<m; j++)
                {
                    for( int k=0; k<n; k++)
                    {
                        cMatrix[i,j] += aMatrix[i,k] * bMatrix[k,j];
                    }
                }
            }

            for(int i=0; i<m; i++)
            {
                for( int j=0; j<m; j++)
                {
                    Console.Write(cMatrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
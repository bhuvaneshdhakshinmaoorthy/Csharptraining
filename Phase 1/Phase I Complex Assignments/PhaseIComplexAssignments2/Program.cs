using System;

namespace PhaseIComplexAssignments2
{
    class  Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            double result = 0;
            for( int i=0; i<num; i++)
            {
                int temp = i;
                int element = 1;
                while(temp>0)
                {
                    element *= temp;
                    temp--;
                }
                double ans = Math.Pow(a,i);
                double another = ans/element;
                result += another;
            }
            Console.WriteLine(Math.Round(result,2));
        }
    }
}
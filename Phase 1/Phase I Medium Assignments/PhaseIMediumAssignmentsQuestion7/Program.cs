using System;

namespace PhaseIMediumAssignmentsQuestion7
{
    class  Program
    {
        public static void Main(string[] args)
        {
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            int size = int.Parse(Console.ReadLine());
            int flag = 1;
            DateTime[] dateArray = new DateTime[size];

            for( int i=0; i<size; i++)
            {
                dateArray[i] = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            }

            if( date.DayOfWeek.ToString() == "Sunday" || date.DayOfWeek.ToString() == "Saturday")
            {
                flag = 0;
            }
            else
            {
                for( int i = 0; i<size; i++)
                {
                    if( dateArray[i] ==date )
                    {
                        flag = 0;
                    }
                }
            }

            if( flag==0)
            {
                Console.WriteLine("Holiday:-)");
            }
            else
            {
                Console.WriteLine("Not an Holiday:-("); 
            }
        }
    }
}
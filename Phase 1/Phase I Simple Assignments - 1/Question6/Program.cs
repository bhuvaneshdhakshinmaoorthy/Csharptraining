using System;

namespace Question6
{
    class  Program
    {
        public static void Main(string[] args)
        {
            string date = Console.ReadLine();

            DateTime dated;
            
            if( DateTime.TryParseExact(date,"dd/MM/yyyy",null, System.Globalization.DateTimeStyles.None, out dated))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }    
        }
    }
}
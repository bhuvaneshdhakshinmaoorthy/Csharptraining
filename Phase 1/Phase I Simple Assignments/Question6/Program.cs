using System;

namespace Question6
{
    class  Program
    {
        public static void Main(string[] args)
        {
            string i = Console.ReadLine();

            if( i=="A" || i=="E" || i=="I" || i=="O" || i=="U" || i=="a" || i=="e" || i=="i" || i=="o" || i=="u" )
            {
                Console.WriteLine("It is a vowel.");
            }
            else
            {
                Console.WriteLine("It is not a vowel.");
            }
        }
    }
}
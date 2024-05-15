using System;

namespace Question13
{
    class  Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            for( int i=name.Length-1; i>=0; i--)
            {
                Console.Write(name[i]);
            }
        }
    }
}
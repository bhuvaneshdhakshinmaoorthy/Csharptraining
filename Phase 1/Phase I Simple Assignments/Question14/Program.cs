using System;

namespace Question14
{
    class  Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int result = 0;
            foreach(char i in name)
            {
                if( i=='A'|| i=='E'||i=='I'||i=='O'||i=='U'||i=='a'||i=='e'||i=='i'||i=='o'||i=='u')
                {
                    result++;
                }
            }
            Console.Write(result);
        }
    }
}
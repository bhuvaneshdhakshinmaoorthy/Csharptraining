using System;

namespace Question10
{
    class  Program
    {
        public static void Main(string[] args)
        {
            string stringThing = Console.ReadLine();

            foreach(char j in stringThing)
            {
                if( j=='A' || j=='E'|| j=='I'|| j=='O'|| j=='U'||j=='a'||j=='e'||j=='i'||j=='o'||j=='u'|| j==' ')
                {
                    Console.Write(j);
                }
            }
        }     
    }
}
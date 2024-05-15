using System;
using Outside;

namespace Inside
{
    class  Program
    {
        public static void Main(string[] args)
        {
            First one = new First();
            Console.WriteLine(one.publicNumber);
            Console.WriteLine(one.privateOut);

            Second two = new Second();
            two.SecondMethod();

            Console.WriteLine(one.internalNumber);

            Third three = new Third();
            Console.WriteLine(three.thirdPublic);
            // Console.WriteLine(three.thirdInternal);
             

        }
    }
}
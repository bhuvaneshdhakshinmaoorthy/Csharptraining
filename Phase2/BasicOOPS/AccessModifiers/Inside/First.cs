using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Outside;

namespace Inside
{
    public class First:Third
    {
        public int publicNumber = 10; 
        private int privateNumber = 20;

        protected int protectedNumber = 30;

        public int privateOut{get{return privateNumber;}}

        internal int internalNumber =  40;

        public int protectedInternalOut{get{return protectedInternal}}
    }

    public class Second:First
    {
        public void SecondMethod()
    {
        First one = new First();
        System.Console.WriteLine(publicNumber);
        Console.WriteLine(protectedNumber);
        Console.WriteLine(internalNumber);
        // System.Console.WriteLine(one.privateNumber);
    }
    }

    
} 
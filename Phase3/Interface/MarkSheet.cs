using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public class MarkSheet : IMarkDetails
    {
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }

        public MarkSheet(int mark1,int mark2,int mark3)
        {
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
        }

        public void GetMarks(int mark1,int mark2,int mark3)
        {
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
        }
    }
}
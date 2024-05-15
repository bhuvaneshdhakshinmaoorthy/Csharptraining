using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial2
{
    public partial class StudentInfo
    {
        public StudentInfo(string name, string gender, DateTime dob, long mobile, double physics, double chemistry, double maths)
        {
            _studentID++;
            StudentID = "SID" + _studentID;
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface2
{
    public class StudentInfo : IDisplayInfo
    {
        private int _studentID = 1000;
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Mobile { get; set; }

        public StudentInfo(string name, string fatherName, long mobile)
        {
            _studentID++;
            StudentID = "SID" + _studentID;
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
        }
        public string Display()
        {
            return $"{StudentID} {Name} {FatherName} {Mobile}";
        }
    }
}
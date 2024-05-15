using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;


namespace Partial1
{
    public partial class EmployeeInfo
    {
        public EmployeeInfo(string name, string gender, DateTime dob, long mobile)
        {
            Name = name;
            Gender = gender;
            DOB = dob;
            Mobile = mobile;
        }
    }
}
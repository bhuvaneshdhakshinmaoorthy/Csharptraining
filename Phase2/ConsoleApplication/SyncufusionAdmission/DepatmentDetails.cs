using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncufusionAdmission
{
    public class DepartmentDetails
    {
        private static int s_departmentID = 100;

        public string DepartmentID { get;}
        public string DepartmentName { get; set; }
        public int NumberOfSeats { get; set; }

        public DepartmentDetails(string departmentName,int numberOfSeats)
        {
            s_departmentID++;
            DepartmentID = "DID" + s_departmentID;
            DepartmentName = departmentName;
            NumberOfSeats = numberOfSeats;
        }

        public DepartmentDetails(string department)
        {
            string[] values = department.Split(",");
            DepartmentID = values[0];
            s_departmentID = int.Parse(values[0].Remove(0,3));
            DepartmentName = values[1];;
            NumberOfSeats = int.Parse(values[2]);
        }
    }
}
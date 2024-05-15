using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncufusionAdmission
{
    public enum AdmissionStatus{Select,Admitted,Cancelled}
    public class AdmissionDetails
    {
        private static int s_admissionID = 1000;
        public string AdmissionID { get; }
        public string StudentID { get; set; }
        public string DepartmentID { get; set; }
        public DateTime AdmissionDate { get; set; }
        public AdmissionStatus AdmissionStatus { get; set; }

        public AdmissionDetails(string studentID,string departmentID,DateTime admissionDate,AdmissionStatus admissionStatus)
        {
            s_admissionID++;
            AdmissionID = "AID" + s_admissionID;
            StudentID = studentID;
            DepartmentID = departmentID;
            AdmissionDate = admissionDate;
            AdmissionStatus = admissionStatus;
        }
        public AdmissionDetails(string admission)
        {
            string[] values = admission.Split(",");
            AdmissionID = values[0];
            s_admissionID = int.Parse(values[0].Remove(0,3));
            StudentID = values[1];
            DepartmentID = values[2];
            AdmissionDate = DateTime.Parse(values[3]);
            AdmissionStatus = Enum.Parse<AdmissionStatus>(values[4]);
        }
    }
}
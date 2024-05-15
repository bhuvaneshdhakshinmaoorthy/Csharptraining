using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed2
{
    public sealed class PatientInfo
    {
        private int _patientID = 2000;
        public string PatientID { get; }
        public string Name { get; set; }
        public string FatherName { get; }
        public int BedNo { get; }
        public string NativePlace { get; }
        public string AdmittedFor { get; }

        public PatientInfo(string name, string fatherName,int bedNo, string nativePlace, string admittedFor)
        {
            _patientID++;
            PatientID = "PID" + _patientID;
            Name = name;
            FatherName = fatherName;
            BedNo = bedNo;
            NativePlace = nativePlace;
            AdmittedFor = admittedFor;
        }
        public string DisplayInfo()
        {
            return $"{PatientID} {Name} {FatherName} {BedNo} {NativePlace} {AdmittedFor}";
        }
    }
}
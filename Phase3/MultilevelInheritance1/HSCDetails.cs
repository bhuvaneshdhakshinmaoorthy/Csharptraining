using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance1 
{
    public class HSCDetails : StudentInfo
    {
        private int _hcnNumber = 2000;
        public string HSCMarksheetNumber { get; set; }
        public double Physics { get; set; }
        public double Chemistry { get; set; }
        public double Maths { get; set; }
        public double Total { get; set; }
        public double PercentageMarks { get; set; }

        public HSCDetails(string name, string fatherName, long phone, string mail, DateTime dob, string gender, int standard, string branch, string academicYear , double physics, double chemistry, double maths) : base(name, fatherName, phone, mail, dob, gender, standard, branch, academicYear)
        {
            _hcnNumber++;
            HSCMarksheetNumber = "HSC" + _hcnNumber;
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
            Total = Physics + Chemistry + Maths;
            PercentageMarks = Total/300 * 100;
            // Total= total;
            // PercentageMarks = percentageMarks;
        }
        public void GetMarks()
        {

        }
        public void Calculate()
        {
            Total = Physics + Chemistry + Maths;
            PercentageMarks = (Total/300) * 100;
        }
        public string ShowMarkSheet()
        {
            
            return $"{HSCMarksheetNumber} {Standard} {Branch} {AcademicYear} {RegisterNumber} {Total} {PercentageMarks+"%"}";
        }
    }
}
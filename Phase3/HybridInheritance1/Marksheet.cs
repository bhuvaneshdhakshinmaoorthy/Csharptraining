using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HybridInheritance1
{
    public class Marksheet : TheoryExamMarks, ICalculate
    {
        private int _markSheetNumber = 9000;
        public string MarksheetNumber { get; }
        public DateTime DateOfIssue { get; set; }
        public double Total { get; set; }
        public double Percentage { get; set; }
        public double ProjectMark { get; set; }
        double Semester1 ;
        double Semester2 ; 
        double Semester3 ; 
        double Semester4 ; 
        public Marksheet(string name, string fatherName, long phone, DateTime dob, string gender,double[] sem1, double[] sem2, double[] sem3, double[] sem4, DateTime dateOfIssue, double projectMark): base( name, fatherName, phone, dob, gender, sem1, sem2, sem3, sem4)
        {
            _markSheetNumber++;
            MarksheetNumber = "Mark" + _markSheetNumber;
            DateOfIssue = dateOfIssue;
            ProjectMark = projectMark;
            Semester1 = sem1[0] + sem1[1] + + sem1[2]+ sem1[3]+ sem1[4]+ sem1[5];
            Semester2 = sem2[0] + sem2[1] + + sem2[2]+ sem2[3]+ sem2[4]+ sem2[5];
            Semester3 = sem3[0] + sem3[1] + + sem3[2]+ sem3[3]+ sem3[4]+ sem3[5];
            Semester4 = sem4[0] + sem4[1] + + sem4[2]+ sem4[3]+ sem4[4]+ sem4[5];
        }
        public void Calculate()
        {
            Total = Semester1 + Semester2 + Semester3 + Semester4 + ProjectMark;
            Percentage = Total/2500 * 100;
        }
        public string ShowMarkSheet()
        {
            return $"{MarksheetNumber} {RegistrationNumber} {Name} {FatherName} {DOB.ToString("dd/MM/yyyy")} DOI:{DateOfIssue.ToString("dd/MM/yyyy")} {Percentage + "%"}";
        }
    }
}
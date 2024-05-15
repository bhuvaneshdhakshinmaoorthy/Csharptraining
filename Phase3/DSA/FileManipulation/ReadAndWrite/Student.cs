using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    public enum Gender{Select,Male,Female,Others}
    public class Student
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender StudentGender { get; set; }
        public DateTime DOB { get; set; }
        public double TotalMark { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial1
{
    public partial class EmployeeInfo
    {
        public void Update()
        {

        }
        public void Display()
        {
            System.Console.WriteLine($"Name: {Name} Gender: {Gender} DOB: {DOB} Mobile: {Mobile}");
        }
    }
}
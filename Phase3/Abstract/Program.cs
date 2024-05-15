using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace Abstract;

class Program
{
    public static void Main(string[] args)
    {
        Syncfusion syncfusion = new Syncfusion("SF4606","Ravi","Syncfusion");
        TCS tcs = new TCS("TS66","Bhuvanesh","TCS");
        List<Salary> salaries = new List<Salary>();
        salaries.Add(syncfusion);
        salaries.Add(tcs);
    }
}
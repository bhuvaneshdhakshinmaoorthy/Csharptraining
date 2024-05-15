using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

namespace ReadAndWrite
{
    class Program
    {
        public static void Main(string[] args)
        {
            if (!Directory.Exists("TestFolder"))
            {
                Directory.CreateDirectory("TestFolder");
                System.Console.WriteLine("Folder Created");
            }
            else { System.Console.WriteLine("Folder Already Exists"); }

            // for csv file
            if (!File.Exists("TestFolder/Data.csv"))
            {
                File.Create("TestFolder/Data.csv");
                System.Console.WriteLine("File Created");
            }
            else { System.Console.WriteLine("File Already Exists"); }

            // for Json file
            if (!File.Exists("TestFolder/Data1.json"))
            {
                File.Create("TestFolder/Data1.json");
                System.Console.WriteLine("File Created");
            }
            else { System.Console.WriteLine("File Already Exists"); }

            List<Student> studentList = new List<Student>();
            studentList.Add(new Student() { Name = "Bhuvanesh", FatherName = "Dhakshinamoorthy", StudentGender = Gender.Male, DOB = new DateTime(2001, 07, 06), TotalMark = 100 });
            studentList.Add(new Student() { Name = "Bharathi", FatherName = "Dhakshinamoorthy", StudentGender = Gender.Female, DOB = new DateTime(1997, 11, 10), TotalMark = 100 });
            studentList.Add(new Student() { Name = "Prakash", FatherName = "Dhakshinamoorthy", StudentGender = Gender.Male, DOB = new DateTime(1994, 01, 06), TotalMark = 100 });
            WriteToCSV(studentList);
            ReadToCSV();
            // WriteToJSON(studentList);
            // ReadtoJSON();
        }
        static void WriteToCSV(List<Student> studentList)
        {
            // for Opening that file
            StreamWriter sw = new StreamWriter("TestFolder/Data.csv"); 
            foreach(Student student in studentList)
            {
                // object info convert into line
                string line = student.Name + "," + student.FatherName + "," + student.StudentGender + "," + student.DOB.ToString("dd/MM/yyyy") + "," + student.TotalMark;
                // line added to file
                sw.WriteLine(line);
            }
            sw.Close();
        }
        static void ReadToCSV()
        {
            StreamReader sr = new StreamReader("TestFolder/Data.csv");
            List<Student> newList = new List<Student>();
            string line = sr.ReadLine();
            while(line!=null)
            {
                string[] values = line.Split(",");
                if(values[0]!="")
                {
                    Student student = new Student()
                    {
                        Name=values[0],
                        FatherName = values[1],
                        StudentGender = Enum.Parse<Gender>(values[2]),
                        DOB = DateTime.ParseExact(values[3],"dd/MM/yyyy",null),
                        TotalMark = int.Parse(values[4]) 
                    };
                    newList.Add(student);
                }
                line = sr.ReadLine();
            }
            sr.Close();
            foreach(Student student in newList)
            {
                System.Console.WriteLine($"Name: {student.Name} \nFatherName: {student.FatherName} \nStudentGender: {student.StudentGender} \nDOB: {student.DOB.ToString("dd/MM/yyyy")} \nTotalMark: {student.TotalMark}");
            }
        }

        static void WriteToJSON( List<Student> studentList)
        {
            StreamWriter sw = new StreamWriter("TestFolder/Data1.json");
            var option = new JsonSerializerOptions
            {
                WriteIndented=true
            };
            string jsonData = JsonSerializer.Serialize(studentList,option);

            sw.WriteLine(jsonData);
            sw.Close();
        }
        static void ReadtoJSON()
        {
            List<Student> students = JsonSerializer.Deserialize<List<Student>>(File.ReadAllText("TestFolder/Data1.json"));
            foreach(Student student in students)
            {
                System.Console.WriteLine($"Name: {student.Name} \nFatherName: {student.FatherName} \nStudentGender: {student.StudentGender} \nDOB: {student.DOB.ToString("dd/MM/yyyy")} \nTotalMark: {student.TotalMark}");
            }
        }
    }
}
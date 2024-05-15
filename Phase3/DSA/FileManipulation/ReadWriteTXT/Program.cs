using System;
using System.IO;

namespace ReadWriteTXT
{
    class Program
    {
        public static void Main(string[] args)
        {
            if(!Directory.Exists("TestFolder"))
            {
                Directory.CreateDirectory("TestFolder");
                System.Console.WriteLine("Folder Created");
            }
            else{System.Console.WriteLine("Folder Already Exists");}

            if(!File.Exists("TestFolder/MyText.txt"))
            {
                File.Create("TestFolder/MyText.txt").Close( );
                System.Console.WriteLine("File Created: MyText.txt");
            }
            else{System.Console.WriteLine("File Already Exists");}

            System.Console.WriteLine("Select 1.Read from file 2. Write to file");
            int option = int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    StreamReader sr = new StreamReader("TestFolder/MyText.txt");
                    string data = sr.ReadLine();
                    while(data!=null)
                    {
                        System.Console.WriteLine(data);
                        data = sr.ReadLine();
                    }
                    break;
                }
                case 2:
                {
                    string[] contents = File.ReadAllLines("TestFolder/MyText.txt");

                    StreamWriter sw = new StreamWriter("TestFolder/MyText.txt");
                    System.Console.WriteLine("Write whatever you want");
                    string newContent = Console.ReadLine();
                    string old = "";
                    foreach(string line in contents)
                    {
                        old += line + "\n";
                    }
                    old += newContent  + "\n";
                    sw.WriteLine(old);

                    sw.Close();
                    break;
                }
            }
        }
    }
}
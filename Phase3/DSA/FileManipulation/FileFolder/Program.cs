using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace FileFolder
{
    class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\BhuvaneshDhakshinamo\OneDrive - Syncfusion\Desktop\DSA\FileManipulation\MyFolder";
            string folderPath = path + "/Bhuvanesh";
            if (!Directory.Exists(folderPath))
            {
                System.Console.WriteLine("Creating folder....");
                Directory.CreateDirectory(folderPath);
            }
            else
            {
                System.Console.WriteLine("Folder Already Exists");
            }
            string filePath = path + "/myFile.txt";
            if (!File.Exists(filePath))
            {
                System.Console.WriteLine("Creating File...");
                File.Create(filePath);
            }
            else
            {
                System.Console.WriteLine("File Already Exists");
            }

            System.Console.WriteLine("Select 1.Create Folder 2.Create File 3.Delete Folder 4.Delete File");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        System.Console.WriteLine("Enter folder name to create");
                        string folderName = Console.ReadLine();
                        string newFolder = path + "/" + folderName;
                        if (!Directory.Exists(newFolder))
                        {
                            System.Console.WriteLine($"Folder created: {folderName}");
                            Directory.CreateDirectory(newFolder);
                        }
                        else
                        {
                            System.Console.WriteLine("Folder Already Exists");
                        }
                        break;
                    }
                case 2:
                    {
                        System.Console.WriteLine("Enter file name to create");
                        string fileName = Console.ReadLine();
                        System.Console.WriteLine("Enter file extension");
                        string extension = Console.ReadLine();
                        string newFile = path + "/" + fileName + "." + extension;
                        if (!File.Exists(newFile))
                        {
                            System.Console.WriteLine($"File Created: {fileName}.{extension}");
                            File.Create(newFile);
                        }
                        else
                        {
                            System.Console.WriteLine("File Already Exists");
                        }
                        break;
                    }
                case 3:
                    {
                        foreach (string path1 in Directory.GetDirectories(path))
                        {
                            System.Console.WriteLine(path1);
                        }
                        System.Console.WriteLine("Select a folder name you wish to delete");
                        string folderDelete = Console.ReadLine();
                        bool flag = true;
                        foreach (string path1 in Directory.GetDirectories(path))
                        {
                            if (path1.Contains(folderDelete))
                            {
                                flag = false;
                                Directory.Delete(path1);
                                System.Console.WriteLine($"Folder Deleted: {folderDelete}");
                                break;
                            }
                        }
                        if (flag)
                        {
                            System.Console.WriteLine("Folder doesn't exists");
                        }
                        break;
                    }
                case 4:
                    {
                        foreach (string file1 in Directory.GetFiles(path))
                        {
                            System.Console.WriteLine(file1);
                        }
                        System.Console.WriteLine("Enter a file name with extension to delete");
                        string fileDelete = Console.ReadLine();
                        bool flag = true;
                        foreach (string file1 in Directory.GetFiles(path))
                        {
                            if (file1.Contains(fileDelete))
                            {
                                flag = false;
                                File.Delete(file1);
                                System.Console.WriteLine($"File Deleted: {file1}");
                                break;
                            }
                        }
                        if(flag)
                        {
                            System.Console.WriteLine("File doesn't exist");
                        }
                        break;
                    }

            }
        }
    }
}
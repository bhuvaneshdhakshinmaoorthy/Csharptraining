using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism3
{
    public class CSEDepartment : Library
    {
        private static int s_serialNumber = 5000;
        public string SerialNumber { get; set; }
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override int Year { get; set; }

        public CSEDepartment(string authorName, string bookName, string publisherName, int year)
        {
            s_serialNumber++;
            SerialNumber = "CSE" + s_serialNumber;
            AuthorName = authorName;
            BookName = bookName;
            PublisherName = publisherName;
            Year = year;
        }

        public override void SetBookInfo()
        {

        }
        public override string DisplayInfo()
        {
            return $"{SerialNumber} {AuthorName} {BookName} {PublisherName} {Year}";
        }
    }
}
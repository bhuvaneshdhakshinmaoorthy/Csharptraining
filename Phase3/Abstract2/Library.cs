using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract2
{
    public abstract class Library
    {
        private  int _serialNumber = 1000;
        public string SerialNumber1 { get; set; }
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract int Year { get; set; }
        public abstract void SetBookInfo();
        public abstract string DisplayInfo();
    }
}
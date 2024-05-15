using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryManagement
{
    public enum Status {Select,Borrowed,Returned}
    public class BorrowDetails
    {
        private static int s_borrowID = 2000;
        public string BorrowID { get; }
        public string BookID { get; set; }
        public string UserID { get; set; }
        public DateTime BorrowedDate { get; set; }
        public int BorrowBookCount { get; set; }
        public Status Status { get; set; }
        public double PaidFineAmount { get; set; }

        public BorrowDetails(string bookID,string userID,DateTime borrowedDate,int borrowBookCount,Status status,double paidFineAmount)
        {
            s_borrowID++;
            BorrowID = "LB" + s_borrowID;
            BookID = bookID;
            UserID = userID;
            BorrowedDate = borrowedDate;
            BorrowBookCount = borrowBookCount;
            Status = status;
            PaidFineAmount = paidFineAmount;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibraryManagement
{
    public class Operation
    {
        static List<UserDetails> userDetailsList = new List<UserDetails>();
        static List<BookDetails> bookList = new List<BookDetails>();
        static List<BorrowDetails> borrowList = new List<BorrowDetails>();
        static UserDetails currentLoginUser;
        public static void AddDefaultData()
        {
            UserDetails user1 = new UserDetails("Ravichandran", Gender.Male, Department.EEE, 9938388333, "ravi@gmail.com", 100);
            UserDetails user2 = new UserDetails("Priyadharshini", Gender.Female, Department.CSE, 9944444455, "priya@gmail.com", 150);
            userDetailsList.Add(user1);
            userDetailsList.Add(user2);
            BookDetails book1 = new BookDetails("C#", "Author1", 3);
            BookDetails book2 = new BookDetails("HTML", "Author2", 5);
            BookDetails book3 = new BookDetails("CSS", "Author1", 3);
            BookDetails book4 = new BookDetails("JS", "Author1", 3);
            BookDetails book5 = new BookDetails("TS", "Author2", 2);
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);
            bookList.Add(book5);
            BorrowDetails borrow1 = new BorrowDetails("BID1001", "SF3001", new DateTime(2023, 09, 10), 2, Status.Borrowed, 0);
            BorrowDetails borrow2 = new BorrowDetails("BID1003", "SF3001", new DateTime(2023, 09, 12), 1, Status.Borrowed, 0);
            BorrowDetails borrow3 = new BorrowDetails("BID1004", "SF3001", new DateTime(2023, 09, 14), 1, Status.Returned, 16);
            BorrowDetails borrow4 = new BorrowDetails("BID1002", "SF3002", new DateTime(2023, 09, 11), 2, Status.Borrowed, 0);
            BorrowDetails borrow5 = new BorrowDetails("BID1005", "SF3002", new DateTime(2023, 09, 09), 1, Status.Returned, 20);
            borrowList.Add(borrow1);
            borrowList.Add(borrow2);
            borrowList.Add(borrow3);
            borrowList.Add(borrow4);
            borrowList.Add(borrow5);
            foreach (UserDetails user in userDetailsList)
            {
                Console.WriteLine($"| {user.UserID,-10} |  {user.UserName,-15} | {user.Gender,-10} | {user.Department,-10} | {user.MobileNumber,-10} | {user.MailID,-15} | {user.WalletBalance,-10} |");
            }
            foreach (BookDetails book in bookList)
            {
                Console.WriteLine($"| {book.BookID,-10} | {book.BookName,-10} | {book.AuthorName,-10} | {book.BookCount,-10} |");
            }
            foreach (BorrowDetails borrow in borrowList)
            {
                Console.WriteLine($"| {borrow.BorrowID,-10} | {borrow.BookID,-10} | {borrow.UserID,-10} | {borrow.BorrowedDate.ToString("dd/MM/yyyy"),-10} | {borrow.BorrowBookCount,-10} | {borrow.Status,-15} | {borrow.PaidFineAmount,-10} |");
            }
        }

        public static void MainMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine("1.User Registration \n2.User Login \n3.Exit");
                int userDecision1 = int.Parse(Console.ReadLine());
                switch (userDecision1)
                {
                    case 1:
                        {
                            UserRegistration();
                            break;
                        }
                    case 2:
                        {
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void UserRegistration()
        {
            Console.WriteLine("Registration Process Selceted");
            Console.WriteLine("Enter your Name");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your Gender: Male,Female,Others");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
            Console.WriteLine("Enter your Department: ECE,EEE,CSE");
            Department department = Enum.Parse<Department>(Console.ReadLine(), true);
            Console.WriteLine("Enter your Mobile Number");
            long mobileNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter your MailID");
            string mailID = Console.ReadLine();
            Console.WriteLine("Enter your Wallet balance");
            double walletBalance = double.Parse(Console.ReadLine());

            UserDetails user = new UserDetails(userName, gender, department, mobileNumber, mailID, walletBalance);
            userDetailsList.Add(user);
            Console.WriteLine($"Your registration was done successfully. Your user ID is {user.UserID}");
        }
        public static void UserLogin()
        {
            Console.WriteLine("Login process selected");
            Console.WriteLine("Enter your UserID");
            string checkUserID = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (UserDetails user in userDetailsList)
            {
                if (user.UserID == checkUserID)
                {
                    flag = false;
                    currentLoginUser = user;
                    SubMenu();
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("Invalid User ID. Please enter a valid one");
            }
        }
        public static void SubMenu()
        {
            bool flag = true;
            do
            {
                Console.WriteLine($"1.Borrow book \n2.Show borrowed history \n3.Return books \n4.Wallet recharge \n5.Exit");
                int userDecision2 = int.Parse(Console.ReadLine());
                switch (userDecision2)
                {
                    case 1:
                        {
                            BorrowBook();
                            break;
                        }
                    case 2:
                        {
                            ShowBorrowedHistory();
                            break;
                        }
                    case 3:
                        {
                            ReturnBooks();
                            break;
                        }
                    case 4:
                        {
                            WalletRecharge();
                            break;
                        }
                    case 5:
                        {
                            flag = false;
                            break;
                        }
                }
            } while (flag);
        }
        public static void BorrowBook()
        {
            // 1.Show the list of Books available by printing BookID, BookName, AuthorName, BookCount.
            foreach (BookDetails book in bookList)
            {
                Console.WriteLine($"| {book.BookID,-10} | {book.BookName,-10} | {book.AuthorName,-10} | {book.BookCount,-10} |");
            }
            // 2.Then Ask the user to pick one book by Asking “Enter Book ID to borrow”.
            Console.WriteLine("Enter the BookId to borrow");
            string checkBookId = Console.ReadLine().ToUpper();
            bool flag = true;
            foreach (BookDetails book in bookList)
            {
                // 3.Check whether “BookID” is available or not. 
                if (checkBookId == book.BookID)
                {
                    flag = false;
                    Console.WriteLine("Enter the count of the book");
                    int borrowBookCount = int.Parse(Console.ReadLine());
                    // 5.Check the book count availability of the book selected. 
                    if (book.BookCount >= borrowBookCount)
                    {
                        // 6. If the book is available to borrow,
                        // a. need to check whether the user already have any borrowed book. Because user can have a maximum of only 3 borrowed books at a time. 
                        int count = 0;
                        foreach (BorrowDetails borrow in borrowList)
                        {
                            if (currentLoginUser.UserID == borrow.UserID && borrow.Status == Status.Borrowed)
                            {
                                count += borrow.BorrowBookCount;
                            }
                        }
                        if (count < 3)
                        {
                            // count>=borrowBookCount && count < 3
                            if (borrowBookCount<=3 && (borrowBookCount + count)<=3)
                            {
                                // 7. Else allocate the book to the user and set status of the Booking Details as "Borrowed” and set the “BorrowedDate” as today’s date and “PaidFineAmount” as 0. 
                                // a. Create the Borrow Details object then store it and show “Book Borrowed successfully”.
                                BorrowDetails borrow = new BorrowDetails(book.BookID, currentLoginUser.UserID, DateTime.Today, borrowBookCount, Status.Borrowed, 0);
                                borrowList.Add(borrow);
                                book.BookCount -= borrowBookCount;
                                Console.WriteLine("Book Borrowed Successfully");
                            }
                            // c. If the user’s already borrowed book count and requested book count exceeds 3 count, then show “You can have maximum of 3 borrowed books. Your already borrowed books count is {BorrowBookCount} and requested count is {Current Requested Count}, which exceeds 3 ”.
                            else
                            {
                                Console.WriteLine($"You can have maximum of 3 borrowed books. Your already borrowed books count is {count} and requested count is {borrowBookCount}, which exceeds 3 ");
                            }
                        }
                        // b.If user having 3 borrowed books already then show “You have borrowed 3 books already”.
                        else
                        {
                            Console.WriteLine("You have borrowed 3 books already");
                        }
                    }
                    // a. If there is no book available, display as “Books are not available for the selected count”. 
                    // b.And print the next available date of book by getting that book’s “BorrowedDate” from the borrowed history information and adding with 15 days  the borrowed date of that book. 
                    // c.Show “The book will be available on {borrowed date + 15 days}”.  
                    else
                    {
                        foreach (BorrowDetails borrow in borrowList)
                        {
                            if (checkBookId == borrow.BookID && borrow.Status == Status.Borrowed)
                            {
                                Console.WriteLine($"Books are not available for the selected count. \nThe book will be available on {borrow.BorrowedDate.AddDays(15).ToString("dd/MM/yyyy")}");
                            }
                        }
                    }
                }
            }
            // 4. If not available display “ Invalid Book ID, Please enter valid ID”, else ask the user to “Enter the count of the book”. Then,
            if (flag)
            {
                Console.WriteLine("Invalid BookID,Please enter valid ID");
            }
        }
        public static void ShowBorrowedHistory()
        {
            bool flag = true;
            foreach (BorrowDetails borrow in borrowList)
            {
                if (borrow.UserID == currentLoginUser.UserID)
                {
                    flag = false;
                    Console.WriteLine($"| {borrow.BorrowID,-10} | {borrow.BookID,-10} | {borrow.UserID,-10} | {borrow.BorrowedDate.ToString("dd/MM/yyyy"),-10} | {borrow.BorrowBookCount,-10} | {borrow.Status,-15} | {borrow.PaidFineAmount,-10} |");

                }
            }
            if (flag)
            {
                Console.WriteLine("You didn't have any borrowed book");
            }
        }
        public static void ReturnBooks()
        {
            // 1.Show the borrowed book details of current user whose status is “borrowed” also Print the return date of each book (Return date will be 15 days after borrowing a book).  
            bool flag = true;
            foreach (BorrowDetails borrow in borrowList)
            {
                if (currentLoginUser.UserID == borrow.UserID && borrow.Status == Status.Borrowed)
                {
                    flag = false;
                    DateTime returnDate = borrow.BorrowedDate.AddDays(15);
                    if (DateTime.Today < returnDate)
                    {
                        Console.WriteLine($"| {borrow.BorrowID,-10} | {borrow.BookID,-10} | {borrow.UserID,-10} | {borrow.BorrowedDate.ToString("dd/MM/yyyy"),-10} | {borrow.BorrowBookCount,-10} | {borrow.Status,-15} | {borrow.PaidFineAmount,-10} | Return Date:{borrow.BorrowedDate.AddDays(15).ToString("dd/MM/yyyy"),-15}");

                    }
                    // 2.If the return date is elapsed more than 15 days then calculate and show the fine amount (Rs. 1 / Day) for each book.
                    else
                    {
                        double differ = (DateTime.Today - returnDate).Days;
                        double fineAmount = differ * 1;
                        Console.WriteLine($"| {borrow.BorrowID,-10} | {borrow.BookID,-10} | {borrow.UserID,-10} | {borrow.BorrowedDate.ToString("dd/MM/yyyy"),-10} | {borrow.BorrowBookCount,-10} | {borrow.Status,-15} | {borrow.PaidFineAmount,-10} | Return Date:{borrow.BorrowedDate.AddDays(15).ToString("dd/MM/yyyy"),-15} | FineAmount:{fineAmount}");

                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("You dont have any book to  return");
            }
            // 3.Ask him to select the BorrowedID to return book and validate that ID. 
            else
            {
                Console.WriteLine("Enter the BorrowedID to return the book");
                string checkBorrowID = Console.ReadLine().ToUpper();
                bool equal = true;
                foreach (BorrowDetails borrow in borrowList)
                {
                    if (checkBorrowID == borrow.BorrowID && currentLoginUser.UserID == borrow.UserID && borrow.Status == Status.Borrowed)
                    {
                        equal = false;
                        DateTime returnDate = borrow.BorrowedDate.AddDays(15);

                        // 4.If return date is elapsed, 
                        if (returnDate < DateTime.Today)
                        {
                            double differ = (DateTime.Today - returnDate).Days;
                            double fineAmount = differ * 1;
                            
                            // a.then check whether the user have sufficient balance for the fine amount, 
                            if (currentLoginUser.WalletBalance >= fineAmount)
                            {
                                // b.if he has sufficient balance then deduct the fine amount from his Wallet balance and change the Status in Booking History to “Returned” and update the fine amount to the “PaidFineAmount” calculated and show “Book returned successfully”. Also, update the “BookCount”.
                                currentLoginUser.WalletBalance -= fineAmount;
                                borrow.PaidFineAmount = fineAmount;
                                foreach (BookDetails book in bookList)
                                {
                                    if (book.BookID == borrow.BookID)
                                    {
                                        book.BookCount += borrow.BorrowBookCount;
                                    }
                                }
                                borrow.Status = Status.Returned;
                                Console.WriteLine("Book Returned Succeussfully");
                            }
                            // c.else show “Insufficient balance. Please rechange and proceed”. 

                            else
                            {
                                Console.WriteLine("Insufficient balance. Please rechange and proceed");
                            }
                        }

                        // 5.Else, change the Status in Booking History to “Returned” and show Book returned successfully. Also, update the “BookCount”.
                        else
                        {
                            foreach (BookDetails book in bookList)
                            {
                                if (book.BookID == borrow.BookID)
                                {
                                    book.BookCount += borrow.BorrowBookCount;
                                }
                            }
                            borrow.Status = Status.Returned;
                            Console.WriteLine("Book Returned Succeussfully");
                        }

                    }
                }
                if (equal)
                {
                    Console.WriteLine("Invalid BorrowID");
                }
            }
        }
        public static void WalletRecharge()
        {
            Console.WriteLine("Whether do you want to recharge your wallet");
            string opinion = Console.ReadLine().ToUpper();
            if (opinion == "YES")
            {
                Console.WriteLine("Enter the recharge Amount");
                double rechargeAmount = double.Parse(Console.ReadLine());
                Console.WriteLine(currentLoginUser.WalletRechargeMethod(rechargeAmount));
            }
            else
            {
                Console.WriteLine("Cancelled the recharge process");
            }
        }
    }
}
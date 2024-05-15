using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicalStore
{
    public class UserDetails
    {
        private static int s_userID = 1000;
        public string UserID { get; }
        public string UserName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public long PhoneNumber { get; set; }
        public double Balance { get; set; }

        public UserDetails(string userName,int age,string city,long phoneNumber,double balance)
        {
            s_userID++;
            UserID = "UID" + s_userID;
            UserName = userName;
            Age = age;
            City = city;
            PhoneNumber = phoneNumber;
            Balance = balance;
        }

        public UserDetails(string user)
        {
            string[] value = user.Split(",");
            s_userID = int.Parse(value[0].Remove(0,3));
            UserID = value[0];
            UserName = value[1];
            Age = int.Parse(value[2]);
            City = value[3];;
            PhoneNumber = long.Parse(value[4]);
            Balance = double.Parse(value[5]);
        }
    }
}
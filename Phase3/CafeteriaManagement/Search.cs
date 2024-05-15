using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaManagement
{
    public class Search
    {
       
        // public string UserID { get; set; }
        public static UserDetails BinarySearch(string searchElement)
        {
            CustomList<UserDetails> userList = Operation.userList;
            int left = 0, right = Operation.userList.Count-1;
            
            while(left<=right)
            {
                int mid = left + (right - left)/2;
                int answer = searchElement.CompareTo(Operation.userList[mid].UserID);
                if(answer==0)
                {
                    return userList[mid];
                }
                else if(answer==1)
                {
                    left = mid + 1;
                }
                else
                {
                    right = left - 1;
                }
            } 
            return null;
        }
    }
}
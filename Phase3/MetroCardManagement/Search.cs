using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class Search
    {
        public static UserDetails BinarySearch(string searchElement)
        {
            CustomList<UserDetails> userList = Operation.userList;
            int left = 0, right = Operation.userList.Count;
            while (left<=right)
            {
                int mid = left + ( right - left ) / 2;
                int answer = searchElement.CompareTo(Operation.userList[mid].CardNumber);
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
                    right = mid - 1;
                }
            }
            return null;
        }
        public static TicketFareDetails BinarySearches(string searchElement)
        {
            CustomList<TicketFareDetails> ticketFareList = Operation.ticketfareList;
            int left = 0, right = Operation.ticketfareList.Count-1;
            while (left<=right)
            {
                int mid = left + (right-left) /2;
                int answer = searchElement.CompareTo(Operation.ticketfareList[mid].TicketID);
                if(answer==0)
                {
                    return ticketFareList[mid];
                }
                else if(answer==1)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return null;
        }
    }
}
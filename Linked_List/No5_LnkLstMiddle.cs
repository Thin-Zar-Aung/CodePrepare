/*
 * Find middle of the linkedlist
 * Time Complexity : O(n)
 * Space Complexity :O(n)
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Linked_List
{
    internal class No5_LnkLstMiddle
    {
        public int findMiddle(ListNode head)
        {
           
            ListNode fast = head;
            ListNode slow = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            
            return slow.val;
        }
    }
}

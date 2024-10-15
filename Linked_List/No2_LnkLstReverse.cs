using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 *Reverse a LinkedList
 *Time Complexity: O(1)
 *Space Complexity : O(1)
 */
namespace CodePrepare.Linked_List
{
    internal class No2_LnkLstReverse
    {
        public ListNode reverse(ListNode head)
        {
            //head,1,2,3,null
            //null,1<--2,<--3--<head
            //head,3,2,1,null
            ListNode current = head;
            ListNode prev = null;
            while (current != null) {
                ListNode next = current.next;
                current.next = prev;
                prev = current;
                current = next;
            }
            head = prev;
            

            return head;
        }
    }
}

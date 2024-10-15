/*
 * Detect Cycle in a List
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Linked_List
{
    internal class No6_DetectCycle
    {
        public bool IsCycle(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            while(slow!=null && fast !=null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if(slow == fast)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

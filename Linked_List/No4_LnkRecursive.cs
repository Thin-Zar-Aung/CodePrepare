/*
 Recursively reverse a Linked List
Time Complextiy : O(N)
Space Complexity : O(1)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Linked_List
{
    internal class No4_LnkRecursive
    {
        public ListNode recurseive(ListNode head)
        {
            //1,2,3,4,5
            //5--5.next =4
            if (head.next == null || head ==null)
            {
                return head;
            }
            ListNode res = recurseive(head.next);
            head.next.next = head;//if head is 4 //5.next = head
            head.next = null;//current head set to null
            return res;

        }
    }
    }

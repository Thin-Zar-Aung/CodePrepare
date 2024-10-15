/*Reverse Every k elements of a List
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Linked_List
{
    internal class No3_LnkLstReverseK
    {
        public ListNode reverseK(ListNode head, int k)
        {
            //1,2,3,4,5,6,7 (k =4) 
            //Expected result : 4,3,2,1,5,6,7
            //if group less than k no need to reverse 
            //1st reverse 4,3,2,1 tail = 1, newhead =4
            //if rest of node < k no reverse and attach the current node value to tail.next
            ListNode current = head;
            ListNode tail = null;
            ListNode newhead = null;
            while (current != null)
            {
                //crete temp node to check the node count
                ListNode temp = current;
                int count = 0;
                while (temp != null && count < k)
                {
                    temp = temp.next;
                    count++;

                }
                if (count < k)
                {
                    if (tail != null)
                    {
                        tail.next = current;
                    }
                    break;

                }
                ListNode prev = null;
                ListNode grouphead = current;//to store group node head before reverse
                //swap opertion
                for (int i = 0; i < k; i++)
                {
                    ListNode next = current.next;
                    current.next = prev;
                    prev = current;
                    current = next;
                }
                if (newhead == null)
                    newhead = prev;

                //tail
                if (tail != null)
                {
                    tail.next = prev;

                }
                tail = grouphead;


            }
            return newhead == null ? head : newhead;
        }
        }
}

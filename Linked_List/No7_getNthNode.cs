/*
 * Return Nth Node from the end of the List
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Linked_List
{
    internal class No7_getNthNode
    {
        public int getNthNode(ListNode head,int n){
            ListNode first = head;
            ListNode second = head;
            //move second nspace ahead
            for(int i = 0; i < n; i++)
            {
                second = second.next;
            }
            //move together first next is res
            while (second.next != null)
            {
                first = first.next;
                second = second.next;
            }
            return first.next.val;

        }
    }
}

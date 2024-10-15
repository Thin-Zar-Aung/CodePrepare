using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Linked_List
{
    internal class No1_LnkLstInsDel
    {
        //add new node in first node
        //Time Complexity : O(1), Space Complexity : O(1)
        public ListNode insertFirst(ListNode head, ListNode newnode)
        {           
            newnode.next = head;
            
            return newnode;          

        }
        //insert at last node
        //Time Complexity : O(n), Space Complexity : O(1)
        public ListNode insertLast(ListNode head, ListNode newnode)
        { //n1,n2,n3,n4,null-- n4.next=newnode.next=null
            ListNode nhead = head;
            while (nhead.next != null)
            {
                nhead = nhead.next;
            }
            nhead.next = newnode;           
            return head;
        }
        //insert between nodes
        //Time Complexity : O(n), Space Complexity : O(1)
        public ListNode insertbetween(ListNode head,int index,  ListNode newnode){
            ListNode current = head;
            //6,7,9,10 -->6,7,newnode8,9,10
            //newnode.next=node3, node3.next =node4
            for(int i=0; i < index-1; i++)
            {
                current = current.next;
            }
            newnode.next = current.next;
            current.next = newnode;
            return head;
            }
        public ListNode delHeadNode(ListNode head)
        {
            head = head.next;
            return head;
        }
        public ListNode delLastNode(ListNode head)
        {

            ListNode current = head;
            while(current.next.next!=null)
            {
                current = current.next;
            }
            current.next = null;
           
            return head;
        }
        public ListNode delbetween(ListNode head,int index)
        {//1,2,3,4,5 index =2
            ListNode current = head;
            for(int i = 0; i < index - 1; i++)
            {
                current = current.next;
            }
            current.next = current.next.next;
           
            return head;
        }
        public void print( ListNode l)
        {
            while (l != null)
            {
                Console.WriteLine(l.val);
                l = l.next;
            }
        }
    }
}

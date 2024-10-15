using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePrepare.Linked_List
{
    internal class ListNode
    {
        
       public int val;
       public ListNode next;
        public ListNode( int val, ListNode next=null)
        { 
            this.val = val;
            this.next = next;
        }
        
    }
}

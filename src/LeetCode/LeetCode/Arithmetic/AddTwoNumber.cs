using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arithmetic
{
    public class AddTwoNumber
    {
        public ListNode Solution(ListNode l1,ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode list = head;
            int overflow = 0;

            while(l1!=null || l2 !=null)
            {
                int current = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + overflow;

                overflow = current / 10;

                list.next = new ListNode(current % 10);

                list = list.next;

                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }
            if(overflow == 1)
            {
                list.next = new ListNode(overflow); 
            }

            return head.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}

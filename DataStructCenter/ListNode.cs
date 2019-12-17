using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructCenter
{
    public class ListNode
    {
        public int val;

        public ListNode next;

        public ListNode(int x) { val = x; }

        public ListNode Add(int val)
        {
            this.next = new ListNode(val);
            return this.next;
        }
    }
}

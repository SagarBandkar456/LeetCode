using System;
using System.Collections.Generic;
using System.Text;

class Program
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public ListNode RemoveElements(ListNode head, int val)
    {
        if (head == null) return head;

        head.next = RemoveElements(head.next, val);

        if (head.val == val)
            return head = head.next;
        else return head;
    }
    public static void Main(string[] args)
    {

    }
}
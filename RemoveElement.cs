using System;

class RemoveElements
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
    public ListNode RemoveElement(ListNode head, int val)
    {
        if (head == null) return head;

        head.next = RemoveElement(head.next, val);

        if (head.val == val)
            return head = head.next;
        else return head;
    }
}
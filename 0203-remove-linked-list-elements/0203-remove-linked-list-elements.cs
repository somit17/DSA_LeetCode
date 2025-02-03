/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode RemoveElements(ListNode head, int val) {
        if (head == null)
    {
      return head;
    }
      ListNode current = head;
      ListNode prev = null;
      while (current!=null)
      {
        if (current.val == val)
        {
          if (current != head)
          {
            prev.next = current.next;
          }
          else
          {
            head = current.next;
          }
        }
        else
        {
          prev = current;
        }
        current = current.next;
      }
    return head;
    }
}
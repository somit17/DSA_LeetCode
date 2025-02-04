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
    public int PairSum(ListNode head) {
      var (first,second)=MiddleOfLL(head);
      var reverseSecondHalf = ReverseLinkedList(second);
     int maxSum=0; 
      while(first!=null && reverseSecondHalf!=null){
        maxSum=Math.Max(maxSum,first.val+reverseSecondHalf.val);
first=first.next;
reverseSecondHalf=reverseSecondHalf.next;
      }
      return maxSum;
    }
    public (ListNode first,ListNode second) MiddleOfLL(ListNode head){
        if(head==null || head.next==null)
        return (head,null);
        ListNode fast=head,slow=head,prev=null;
        while(fast!=null && fast.next!=null){
            prev=slow;
            fast=fast.next.next;
            slow=slow.next;
        }
        if (prev != null)
        {
            prev.next = null; // The first half ends here
        }
        // Return the two halves
        return (head, slow);
    }
    public ListNode ReverseLinkedList(ListNode head){
        if(head==null){
            return null;
        }
        ListNode prev=null,next=null;
        while(head!=null){
            next=head.next;
            head.next=prev;
            prev=head;
            head=next;
        }
        head=prev;
        return head;
    }
}
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
    public ListNode ReverseList(ListNode head) {
        // if(head==null || head.next==null )
        //     return head;
        // var lastNode = ReverseList(head.next);
        // head.next.next=head;
        // head.next=null;
        return IterativeApproach(head);
    }
    public ListNode IterativeApproach(ListNode head){
        if(head==null)
            return null;
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
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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode();
        ListNode current = dummy;
        int carry=0;
        while(l1!=null || l2!=null || carry > 0){
            int num1 = l1!=null ? l1.val : 0 ;
            int num2 = l2!=null ? l2.val : 0 ;
            int sum = num1 + num2 + carry;
            int digit = sum % 10;
            carry = sum / 10;
            current.next = new ListNode(digit);
            current = current.next;
            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }
        return dummy.next;
    }
}
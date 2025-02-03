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
    public bool IsPalindrome(ListNode head) {
        if(head==null) return false;
        ListNode current = head;
        List<int> resultData = new List<int>();
        while(current!=null){
            resultData.Add(current.val);
            current=current.next;
        }
        int L=0,R=resultData.Count-1;
        while(L<R){
            if(resultData[L]!=resultData[R]){
                return false;
            }
            L++;
            R--;
        }
        return true;
    }
}
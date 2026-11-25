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
        ListNode dummy = new ListNode(0);
        dummy.next = head; 

        ListNode cur = dummy; 
        while(cur.next != null) { 
            if(cur.next.val == val) {
                cur.next = cur.next.next;
            } else { 
                cur = cur.next;
            }
        }

        return dummy.next;
    }
}
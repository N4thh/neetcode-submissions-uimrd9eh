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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode dummy = new ListNode(0); 
        dummy.next = head; 

        int length =0; 
        ListNode temp = head; 
        while(temp !=null){
            length++; 
            temp = temp.next;
        }

        int index = length - n; 
        ListNode cur = dummy; 
        for(int i = 0; i < index ; i++){ 
            cur = cur.next; 
        }
        cur.next = cur.next.next; 

        return dummy.next;
    }
}

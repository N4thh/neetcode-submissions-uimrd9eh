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
        List<ListNode> arr = new List<ListNode>();
        ListNode cur = head;

        while(cur != null){
            arr.Add(cur);
            cur = cur.next;
        }

        ListNode dummy = new ListNode();
        ListNode rs = dummy;
        for(int i = arr.Count - 1; i >= 0; i--) {  
            dummy.next = arr[i];
            if(i == 0) {
                dummy.next.next = null;
            }
            dummy = dummy.next;
        }

        return rs.next;
    }
}
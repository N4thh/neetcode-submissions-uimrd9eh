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
        List<ListNode> arr = new List<ListNode>(); 
        ListNode cur = head; 

        while(cur != null) {
            arr.Add(cur);
            cur = cur.next;
        }

        int count = 0;
        for(int i = arr.Count - 1; i >= 0; i--) {
            count++;
            if(count == n) { 
                if(arr[i].next != null && i != 0) {
                    arr[i-1].next = arr[i].next;
                } else if (arr[i].next == null && i != 0) {
                    arr[i-1].next = null;
                } else if (i == 0 && arr[i].next != null) {
                    head = arr[i+1];
                } else if (i == 0 && arr[i].next == null) {
                    head = null;
                }
            }
        }

        return head;
    }
}
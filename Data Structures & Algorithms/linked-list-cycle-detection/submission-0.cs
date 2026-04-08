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
    public bool HasCycle(ListNode head) {
     HashSet<ListNode> visited = new HashSet<ListNode>();
     while(head != null){ 
        visited.Add(head); 
        head = head.next;
        if(visited.Contains(head)){
            return true;
        }
     }
     return false;

    }
}

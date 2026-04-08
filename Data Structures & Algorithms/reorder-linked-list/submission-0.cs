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
    public void ReorderList(ListNode head) {
        List<ListNode> node = new List<ListNode>();
        ListNode current = head; 
        while(current != null){ 
            node.Add(current); 
            current = current.next; 
        }

        int i=0, j = node.Count -1; 
        while(i <j){ 
            node[i].next = node[j];
            i++;
            node[j].next = node[i];
            j--;
        }
        node[i].next = null;
    }
}

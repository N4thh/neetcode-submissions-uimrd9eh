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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists == null || lists.Length == 0) 
            return  null; 

        var minHeap = new PriorityQueue<ListNode, int>(); 
        foreach(var node in lists){ 
            if(node != null)
                minHeap.Enqueue(node, node.val);
        }

        ListNode dummy = new ListNode(0); 
        ListNode cur = dummy; 
        
        while(minHeap.Count > 0){ 
            ListNode minNode = minHeap.Dequeue();
            cur.next = minNode; 
            cur = cur.next; 

            if(minNode.next != null)
                minHeap.Enqueue(minNode.next, minNode.next.val);
        }
        
        return dummy.next; 
    }
}

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
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        List<ListNode> rev1 = new List<ListNode>();
        while(l1 != null){ 
            rev1.Add(l1); 
            l1 = l1.next;
        } 

        List<ListNode> rev2 = new List<ListNode>(); 
        while(l2 != null){ 
            rev2.Add(l2);
            l2 = l2.next; 
        }

        int degit1 = 0;
        for(int i = rev1.Count -1; i >= 0; i--){
            degit1 = degit1 * 10 + rev1[i].val;
        }

        int degit2 = 0;
        for(int i = rev2.Count -1; i >= 0; i--){
            degit2 = degit2 * 10 + rev2[i].val;
        }

        int result = degit1 + degit2; 

        ListNode dummy = new ListNode(0); 
        ListNode current = dummy; 
        foreach(var c in result.ToString()){ 
            current.next = new ListNode(c - '0'); 
            current = current.next; 
        }

        ListNode prev = null;
        current = dummy.next; 
        while (current != null){
            ListNode temp = current.next; 
            current.next = prev; 
            prev = current; 
            current = temp;
        }

        return prev; 
    }
}
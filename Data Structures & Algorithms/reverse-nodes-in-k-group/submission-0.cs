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
    public ListNode ReverseKGroup(ListNode head, int k) {
        if (head == null || k == 0)
            return head; 
        
        List<int> arr = new List<int>(); 
        ListNode cur = head; 
        while(cur != null){ 
            arr.Add(cur.val); 
            cur = cur.next;
        }

        int groups = arr.Count / k; 
        for(int i = 0; i < groups; i++){ 
            int left = i * k; 
            int right = left + k - 1; 
            while(left < right){ 
                int temp = arr[left]; 
                arr[left] = arr[right]; 
                arr[right] = temp; 

                left++;
                right--;
            }
        }

        ListNode dummy = new ListNode(0); 
        cur = dummy; 
        foreach(int node in arr){ 
            cur.next = new ListNode(node); 
            cur = cur.next;
        }

        return dummy.next;
    }
}

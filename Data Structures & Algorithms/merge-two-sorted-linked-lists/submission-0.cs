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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode(0);
        ListNode result = dummy;

        if(list1 == null || list2 == null)
            return list1 ?? list2; 
        
        while(list1 != null && list2 != null){ 
            if(list1.val < list2.val){ 
                result.next = list1; 
                list1 = list1.next;
            }
            else{
                result.next = list2; 
                list2 = list2.next;
            }
            result = result.next;
        }

        result.next = (list1 != null) ? list1 : list2; 
        return dummy.next;
    }
}
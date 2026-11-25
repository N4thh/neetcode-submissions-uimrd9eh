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
        if(list1 == null || list2 == null) return list1 ?? list2;

        ListNode dummy = new ListNode();
        ListNode rs = dummy; 
        
        while(list1 != null && list2 != null) {
            if(list1.val <= list2.val) {
                dummy.next = list1; 
                list1 = list1.next;
            } else{
                dummy.next = list2; 
                list2= list2.next;
            }
            dummy = dummy.next;
        }

        if(list1 != null) {
            dummy.next = list1;
        }
        if(list2 != null) {
            dummy.next = list2;
        }

        return rs.next;
    }
}
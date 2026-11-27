/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if(head == null) return null; 

        Dictionary<int, Node> memo = new Dictionary<int, Node>();

        List<Node> newArr = new List<Node>();
        List<Node> oldArr = new List<Node>();

        Node dummy = new Node(0);
        Node rs = dummy;
        Node cur = head;

        int i = 0; 
        while(cur != null) {
            dummy.next = new Node(cur.val);
            dummy = dummy.next;

            newArr.Add(dummy);
            oldArr.Add(cur);
            memo[i] = dummy;
            cur = cur.next;
            i++;
        }

        cur = head; 
        dummy = rs.next; 
        while(dummy != null) { 
            int oldRandom = oldArr.IndexOf(cur.random);
            if(memo.ContainsKey(oldRandom)){
                dummy.random = memo[oldRandom];
            }

            dummy = dummy.next;
            cur = cur.next;
        }

        return rs.next;  
    }
}

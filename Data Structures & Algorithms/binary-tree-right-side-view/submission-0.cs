/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public List<int> RightSideView(TreeNode root) {
     List<int> res = new List<int>(); 
     if(root == null)
        return res; 

        Queue<TreeNode> q = new Queue<TreeNode>(); 
        q.Enqueue(root); 

        while(q.Count > 0 ) {
            int curLevel = q.Count; 
            int levelCheck = 1; 
            
            while(curLevel > 0) { 
                TreeNode node = q.Dequeue();         
                curLevel --;
                levelCheck --;
                if(levelCheck == 0)
                    res.Add(node.val);
               
                if(node.right != null) q.Enqueue(node.right);
                if(node.left != null) q.Enqueue(node.left);               
            }
        }
        return res; 
    }
}

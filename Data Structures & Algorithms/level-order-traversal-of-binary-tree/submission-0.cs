/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right  = right;
 *     }
 * }
 */
 
public class Solution {
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> res = new List<List<int>>(); 
        if(root == null)
            return res; 
        
        Queue<TreeNode> queue = new Queue<TreeNode>(); 
        queue.Enqueue(root);
        
        while(queue.Count > 0) {
            int curSize = queue.Count; 
            List<int> curLevel = new List<int>(); 
            
            while(curSize > 0) {
                TreeNode node = queue.Dequeue(); 
                curSize --; 
                curLevel.Add(node.val);

                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);
            }

            res.Add(curLevel);
        }
        return res;
    }
}

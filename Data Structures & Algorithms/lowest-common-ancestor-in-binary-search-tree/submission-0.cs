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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null || root == q || root == p )
            return root; 
        
        var left = LowestCommonAncestor(root.left, p ,q); 
        var right = LowestCommonAncestor(root.right,p ,q); 

        if(left != null && right != null)
            return root; 
        
       return left ?? right;
    }
}

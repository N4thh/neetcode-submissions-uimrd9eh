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

    public int MaxPathSum(TreeNode root) {
        int res = int.MinValue;
        SumDFS(root, ref res);

        return res;
    }
    public int SumDFS(TreeNode node, ref int res) { 
        if(node == null)
            return 0; 
        

        int left = Math.Max(0, SumDFS(node.left, ref res)); 
        int right = Math.Max(0, SumDFS(node.right,ref res));       
        res= Math.Max(res, left + right + node.val);

        return node.val + Math.Max(left, right);
    }
}

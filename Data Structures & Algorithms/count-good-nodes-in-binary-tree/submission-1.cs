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
    public int GoodNodes(TreeNode root) {
        if(root == null)
            return 0;

        return CountGoodNodes(root, root.val);
    }
    public int CountGoodNodes(TreeNode node, int maxValue) { 
        if(node == null)
            return 0; 
        
        int count = 0;
        if(node.val >= maxValue) { 
            count = 1; 
            maxValue = node.val; 
        }

        int leftNode = CountGoodNodes(node.left, maxValue);
        int rightNode = CountGoodNodes(node.right, maxValue);

        return count + leftNode + rightNode;
    }
}

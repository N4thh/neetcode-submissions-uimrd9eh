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
    public int KthSmallest(TreeNode root, int k) {
        if(root == null)
            return 0;
        
        int[] arr = Sort(root);
        return arr[k-1];
    }
    private int[] Sort(TreeNode node, List<int> arr = null) { 
        if(arr == null)
            arr = new List<int>(); 
        if(node == null)
            return arr.ToArray();

        Sort(node.left, arr); 
        arr.Add(node.val);
        Sort(node.right, arr);
        
        return arr.ToArray();
    }
}

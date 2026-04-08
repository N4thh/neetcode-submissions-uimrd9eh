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

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        if(root == null)
            return ""; 
        
        Queue<TreeNode>q = new Queue<TreeNode>();
        List<string> result = new List<string>(); 
        q.Enqueue(root);

        while(q.Count > 0) { 
            var node = q.Dequeue(); 

            if(node == null) {
                result.Add("null"); 
                continue;
            }
            result.Add(node.val.ToString());
            q.Enqueue(node.left);
            q.Enqueue(node.right);
        }
        return String.Join(",",result); 
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        if(string.IsNullOrEmpty(data))
            return null;
        string[] arr = data.Split(",");
        TreeNode root = new TreeNode(int.Parse(arr[0]));

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root); 
        int i = 1; 
        
        while(q.Count > 0 && i < arr.Length) { 
            TreeNode node = q.Dequeue(); 

            if(arr[i] != "null") { 
                node.left = new TreeNode(int.Parse(arr[i]));
                q.Enqueue(node.left);
            }
            i++;

            if(i < arr.Length && arr[i] != "null") {
                node.right = new TreeNode(int.Parse(arr[i]));
                q.Enqueue(node.right);
            }
            i++;
        }

        return root;   
    }
}

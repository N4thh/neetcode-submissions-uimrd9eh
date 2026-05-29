/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        Dictionary<Node, Node> oldToNew = new Dictionary<Node,Node>(); 
        return dfs(node, oldToNew); 
    }
    private Node dfs(Node node, Dictionary<Node,Node>oldToNew) { 
        if(node == null) 
            return null; 
        if(oldToNew.ContainsKey(node))
            return oldToNew[node]; 

        Node copy = new Node(node.val);
        oldToNew[node] = copy; 
        
        foreach(Node nei in node.neighbors) { 
            copy.neighbors.Add(dfs(nei, oldToNew));
        }
        return copy; 
    }
}

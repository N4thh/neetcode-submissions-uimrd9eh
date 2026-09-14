public class Solution {
    public Dictionary<int, List<int>>graph;

    public bool ValidTree(int n, int[][] edges) {
        if (edges.Length != n - 1)
            return false;

        graph = new Dictionary<int, List<int>>(); 
        HashSet<int>visited = new HashSet<int>(); 

        //create Graph
        for(int i = 0; i < edges.Length; i++) { 
            int leftNode = edges[i][0];
            int rightNode = edges[i][1];
            
            if(!graph.ContainsKey(leftNode))
                graph[leftNode] = new List<int>();
            graph[leftNode].Add(rightNode);

            if(!graph.ContainsKey(rightNode))
                graph[rightNode] = new List<int>();
            graph[rightNode].Add(leftNode);
        }

        bool isTree = dfs(visited, -1, 0);
        if(!isTree)
            return false;

        return isTree && visited.Count == n; 
    }

    private bool dfs(HashSet<int>visited, int parentNode, int node) { 
        if(visited.Contains(node))
            return false;
        
        visited.Add(node);

        if(graph.ContainsKey(node)) { 
                foreach(int nextNode in graph[node]) {
                    if(nextNode == parentNode) 
                        continue; 
                    if(!dfs(visited, node, nextNode)) {
                        return false; 
                }
            }
        }

        return true;
    }
}

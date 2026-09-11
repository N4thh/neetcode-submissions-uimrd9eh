public class Solution {
    private Dictionary<int, List<int>>graph;
    private int cycleStart = -1;
    public int[] FindRedundantConnection(int[][] edges) {
        graph = new Dictionary<int, List<int>>(); 
        HashSet<int>cycle = new HashSet<int>();
        HashSet<int> visited = new HashSet<int>();

        int n = edges.Length; 
        for(int i = 0; i < n; i++) { 
            int node = edges[i][0];
            int nextNode = edges[i][1];
            
            if(!graph.ContainsKey(node)) { 
                graph[node] = new List<int>();
            }
            graph[node].Add(nextNode);

            if(!graph.ContainsKey(nextNode)) { 
                graph[nextNode] = new List<int>();
            }
            graph[nextNode].Add(node);
        }

        dfs(cycle, visited, -1, 1);

        for(int i = n -1; i >=0 ; i--) {
            int u = edges[i][0], v = edges[i][1];
            if(cycle.Contains(u) && cycle.Contains(v)) { 
                return new int[] {u,v};
            }
        }
        return new int [0];

        
    }

    private bool dfs(HashSet<int> cycle, HashSet<int> visited, int prevNode, int node) { 
        if(visited.Contains(node)) {
            cycleStart = node;
            return true;
        }
        visited.Add(node);
        
        if(graph.ContainsKey(node)) {
            foreach(var nextNode in graph[node]) {
                if(nextNode == prevNode) 
                    continue;
                if(dfs(cycle, visited, node, nextNode)) {
                    if (cycleStart != -1)
                        cycle.Add(node);

                    if (node == cycleStart)
                        cycleStart = -1;

                    return true;
                }
            }
        }
        return false;
    }
}

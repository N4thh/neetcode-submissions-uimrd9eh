public class Solution {
    public Dictionary<int,List<int>> graph;

    public int CountComponents(int n, int[][] edges) {
        graph = new Dictionary<int,List<int>>();
        HashSet<int> visited = new HashSet<int>();

        if(n == 1)
            return 1;
        for(int i = 0; i < edges.Length ; i++) { 
            int nodeLeft = edges[i][0];
            int nodeRight = edges[i][1];

            if(!graph.ContainsKey(nodeRight)){
                graph[nodeRight] = new List<int>();    
            }  
            graph[nodeRight].Add(nodeLeft);
            
            if(!graph.ContainsKey(nodeLeft)){
                graph[nodeLeft] = new List<int>();        
            }
            graph[nodeLeft].Add(nodeRight);
        }
        
        int rs = 0;
        for(int i = 0; i < n; i++) {
            if(!visited.Contains(i)) {
                rs++;
                dfs(i, visited);
            }
        }
        return rs;
    }

    private void dfs(int node, HashSet<int> visited) {
        if (visited.Contains(node))
            return;

        visited.Add(node);

        if (graph.ContainsKey(node)) {
            foreach (int nextNode in graph[node]) {
                dfs(nextNode, visited);
            }
        }
    }
}

public class Solution {
    public Dictionary<int, List<int>> graph;

    public int CountComponents(int n, int[][] edges) {
        graph = new Dictionary<int, List<int>>(); 
        HashSet<int> visited = new HashSet<int>(); 

        for(int i = 0; i < edges.Length; i++) { 
            int key = edges[i][0];
            int value = edges[i][1];

            if(!graph.ContainsKey(key)) { 
                graph[key] = new List<int>();
            }
            if(!graph.ContainsKey(value)) { 
                graph[value] = new List<int>();
            }

            graph[key].Add(value);
            graph[value].Add(key);
        }

        int countConnected = 0;
        for(int node = 0; node < n; node++) { 
            countConnected += dfs(visited, node) ;
        }

        return countConnected;
    }
    private int dfs(HashSet<int> visited, int node) {
        if(visited.Contains(node))
            return 0;

        visited.Add(node);
        if(graph.ContainsKey(node)) { 
            foreach(int nextNode in graph[node]) { 
                dfs(visited, nextNode);
            }
        }

        return 1; 
    }
}
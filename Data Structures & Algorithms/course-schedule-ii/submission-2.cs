public class Solution {
    private Dictionary<int, List<int>> graph; 
    
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        graph = new Dictionary<int, List<int>>();
        for(int i = 0; i < prerequisites.Length; i++) { 
            int leftNode = prerequisites[i][0], rightNode = prerequisites[i][1]; 
            
            if(!graph.ContainsKey(leftNode))
                graph[leftNode] = new List<int>(); 
            graph[leftNode].Add(rightNode);
        }

        HashSet<int> visited = new HashSet<int>();
        HashSet<int> cycle = new HashSet<int>();
        List<int> rs = new List<int>();
        bool isValid = false;

        for(int i = 0; i < numCourses; i++) {
            isValid = dfs(visited, cycle, rs, i);
            if(!isValid)
                return new int[0];
        }
        
        return rs.ToArray();
    }

    private bool dfs(HashSet<int> visited, HashSet<int> cycle,List<int> rs, int node) {
        if(cycle.Contains(node)) {
            return false;
        }
        if(visited.Contains(node)) {
            return true;
        }

        cycle.Add(node);
        
        if(graph.ContainsKey(node)) { 
            foreach(int nextNode in graph[node]) { 
                if(!dfs(visited,cycle, rs, nextNode)) {
                    return false;
                }
            }
        }

        cycle.Remove(node);
        visited.Add(node);
        rs.Add(node);
        return true;
    }
}
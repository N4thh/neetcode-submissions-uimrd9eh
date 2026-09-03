public class Solution {
    public int total;
    public Dictionary<int, List<int>> dic; 

    public bool ValidTree(int n, int[][] edges) {
        this.total = n;
        dic = new Dictionary<int, List<int>>(); 

        if(edges.Length != n -1)  
            return false;
        
        for(int i = 0; i < edges.Length ; i ++) { 
            int key = edges[i][0];
            int value = edges[i][1];
            if(!dic.ContainsKey(key)) { 
                dic[key] = new List<int>();
            }
            dic[key].Add(value);

            int secondKey = edges[i][1];
            int secondValue = edges[i][0];
            if(!dic.ContainsKey(secondKey)) { 
                dic[secondKey] = new List<int>();
            }
            dic[secondKey].Add(secondValue);
        }

        HashSet<int> visited = new HashSet<int>();
        int parentNode = -1;

        bool result = dfs(parentNode, 0, visited);
        if (!result)
            return false;

        return visited.Count == total;
    }
    private bool dfs(int parentNode, int node, HashSet<int> visited) { 
        if(visited.Contains(node))
            return false;

        visited.Add(node);

        if(dic.ContainsKey(node)) { 
                foreach(int nextNode in dic[node]) {
                    if(nextNode == parentNode) 
                        continue; 
                    if(!dfs(node, nextNode, visited)) {
                        return false; 
                }
            }
        }
        return true;
    }
}

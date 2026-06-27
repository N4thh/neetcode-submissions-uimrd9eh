public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<int>[]graph = new List<int>[numCourses];
        for(int i = 0; i < numCourses; i++) { 
            graph[i] = new List<int>();
        }
        foreach(var p in prerequisites) { 
            graph[p[1]].Add(p[0]); 
        }

        int[] state = new int [numCourses]; 
        for(int i = 0; i < numCourses; i++){ 
            if(!dfs(i, graph,state))
                return false;  
        }
        return true; 
    }
    
    public bool dfs(int node, List<int>[] graph, int[] state) { 
        if(state[node] == 1)
            return false; 
        if(state[node] == 2)
            return true;
        
        state[node] = 1; 
        foreach(var next in graph[node]) { 
            if(!dfs(next, graph,state))
                return false; 
        }
        state[node] = 2; 
        return true; 
    }
}
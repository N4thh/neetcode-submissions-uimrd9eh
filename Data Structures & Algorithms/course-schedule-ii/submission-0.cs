public class Solution {
    public int numCourses; 
    public Dictionary<int,List<int>> dic;

    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        this.numCourses = numCourses;
        dic = new Dictionary<int, List<int>>();

        for(int i = 0; i < prerequisites.Length; i++) { 
            int course = prerequisites[i][1];
            int prereq = prerequisites[i][0];

            if(!dic.ContainsKey(prereq)) {
                dic[prereq] = new List<int>();
            }

            dic[prereq].Add(course);
        }

        List<int> res = new List<int>();
        HashSet<int> visited = new HashSet<int>(); 
        HashSet<int> cycle = new HashSet<int>();

        for(int i = 0; i < numCourses; i++) { 
            if(!dfs(i , res, visited, cycle)) { 
                return new int[0];
            }
        }

        return res.ToArray();
    }

    private bool dfs(int course, List<int> res, HashSet<int> visited, HashSet<int> cycle) {
        if(cycle.Contains(course))
            return false; 

        if(visited.Contains(course))
            return true; 

        cycle.Add(course); 
        
        if(dic.ContainsKey(course)) { 
            foreach(var next in dic[course]) { 
                if(!dfs(next, res, visited, cycle)) { 
                    return false;
                }
            }
        }
        
        cycle.Remove(course); 
        visited.Add(course); 
        res.Add(course); 
        return true;
    }
}

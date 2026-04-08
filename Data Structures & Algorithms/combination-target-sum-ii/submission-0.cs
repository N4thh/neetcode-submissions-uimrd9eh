public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        List<List<int>> res = new List<List<int>>();
        List<int> subnet = new List<int>();
        Array.Sort(candidates);

        void dfs(int start, int sum) {
            if(sum == target) { 
                res.Add(new List<int>(subnet));
                return;
            }

            for(int i = start; i < candidates.Length; i++) {
                if(i > start && candidates[i] == candidates[i-1])
                    continue;
                
                if(sum + candidates[i] > target)
                    break;
            
                subnet.Add(candidates[i]);

                dfs(i+1, sum + candidates[i]); 
                subnet.RemoveAt(subnet.Count - 1);
            }
        }

        dfs(0,0);
        return res;        
    }
}

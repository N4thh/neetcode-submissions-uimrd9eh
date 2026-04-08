public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        List<int> subnet  = new List<int>();
        Array.Sort(nums); 

        void dfs(int start) { 
            res.Add(new List<int>(subnet));
            
            for(int i = start; i < nums.Length; i++) { 
                if(i > start && nums[i] == nums[i-1])
                    continue; 
                
                subnet.Add(nums[i]);
                dfs(i+1); 
                subnet.RemoveAt(subnet.Count -1); 
            }
        }
        dfs(0);
        return res;
    }
}

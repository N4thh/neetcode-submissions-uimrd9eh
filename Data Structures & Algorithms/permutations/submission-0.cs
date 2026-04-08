public class Solution {
    public List<List<int>> Permute(int[] nums) {
        List<List<int>> res = new List<List<int>>(); 
        List<int> subnet = new List<int>(); 

        void dfs() { 
            if(subnet.Count == nums.Length) { 
                res.Add(new List<int>(subnet)); 
                return; 
            }

            for(int i =0; i < nums.Length; i++) { 
                if(subnet.Contains(nums[i]))
                    continue;
                
                subnet.Add(nums[i]); 
                dfs(); 
                subnet.RemoveAt(subnet.Count - 1);
            }
        }
        dfs(); 
        return res; 
    }
}

public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        List<List<int>> res = new List<List<int>>();
        List<int> subnet = new List<int>();
        Array.Sort(nums);

        void dfs(int start, int sum) { 
            if(sum == target) { 
                res.Add(new List<int>(subnet));
                return;
            }

            for(int i = start; i < nums.Length; i++) { 
                if(sum + nums[i] > target)
                    break; 
                
                subnet.Add(nums[i]);

                dfs(i, sum + nums[i]); 
                subnet.RemoveAt(subnet.Count - 1);
            }
        }

        dfs(0,0);
        return res;
    }
}

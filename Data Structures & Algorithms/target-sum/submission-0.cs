public class Solution {
    private Dictionary<(int,int), int> dp; 
    public int FindTargetSumWays(int[] nums, int target) {
        dp = new Dictionary<(int,int), int>();
        return dfs(0, 0, nums, target);
    }

    private int dfs(int i, int sum, int[] nums, int target) {
        if(i == nums.Length)
            return sum == target ? 1 : 0;
        
        var key = (i, sum);
        if(dp.ContainsKey(key))
            return dp[key];
        
        int add = dfs(i+1, sum + nums[i], nums, target);
        int subtract = dfs(i+1, sum - nums[i], nums, target);

        dp[key] = add + subtract;
        return dp[key];
    }
}

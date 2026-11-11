public class Solution {
    private Dictionary<int,int> dp;
    public int Rob(int[] nums) {
        if(nums.Length == 1)
            return nums[0];
            
        dp = new Dictionary<int,int>();        
        int pickFirst = dfs(0, nums[1..]);

        dp = new Dictionary<int,int>();        
        int pickLast = dfs(0, nums[..^1]);

        return Math.Max(pickFirst, pickLast);
    }

    private int dfs(int i,int[] newNums) {
        if(i >= newNums.Length) return 0; 

        if(dp.ContainsKey(i)) return dp[i];
        dp[i] = Math.Max( newNums[i] + dfs(i+2, newNums), dfs(i+1, newNums) );

        return dp[i];
    }
}

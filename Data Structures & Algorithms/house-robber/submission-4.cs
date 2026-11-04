public class Solution {
    private Dictionary<int,int> memo;
    public int Rob(int[] nums) {
        memo = new Dictionary<int,int>();

        if(nums.Length == 1)
            return nums[0];
        
        memo[0] = dfs(0, nums);
        return memo[0];
    }
    
    private int dfs(int i, int[] nums){
        if(i >= nums.Length) return 0;

        if(memo.ContainsKey(i))
            return memo[i];
        
        memo[i] = Math.Max(nums[i] + dfs(i+2, nums), dfs(i+1, nums));
        return memo[i];
    }
}

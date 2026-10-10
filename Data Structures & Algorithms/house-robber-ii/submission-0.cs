public class Solution {
    public Dictionary<int,int>memo;

    public int Rob(int[] nums) {
        if(nums.Length == 1)
            return nums[0];

        memo = new Dictionary<int,int>();
        int a = dfs(0, nums[1..]);
        memo = new Dictionary<int,int>();
        int b = dfs(0, nums[..^1]);

        return Math.Max(a,b);
    }
    private int dfs(int i, int[] nums) {
        if(i >= nums.Length)
            return 0;
        if(memo.ContainsKey(i))
            return memo[i];

        memo[i] = Math.Max(nums[i] + dfs(i+2, nums), dfs(i+1, nums));
        return memo[i];
    }
}
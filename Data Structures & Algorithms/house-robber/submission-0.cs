public class Solution {
    public Dictionary<int,int>memo; 
    public int Rob(int[] nums) {
       memo = new Dictionary<int,int>(); 

       for(int i = 0; i <= nums.Length; i++) { 
            dfs(i, nums);
       }
       return dfs(0,nums);
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
public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        Dictionary<int,int> memo = new Dictionary<int,int>(); 

        if(cost.Length == 0)
            return 0;
        if(memo.ContainsKey(cost.Length))
            return memo[cost.Length];
        
        memo[0] = 0; 
        memo[1] = 0; 

        for(int i = 2; i <= cost.Length; i++) {
            memo[i] = Math.Min((memo[i-1] + cost[i-1]) , (memo[i-2] + cost[i-2]));
        }

        return memo[cost.Length];
    }
}

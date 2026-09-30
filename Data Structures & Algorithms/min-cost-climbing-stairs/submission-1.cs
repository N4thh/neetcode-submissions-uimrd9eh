public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        Dictionary<int,int>memo = new Dictionary<int,int>(); 

        memo[0] = 0;
        memo[1] = 0;

        if(memo.ContainsKey(cost.Length))
            return memo[cost.Length]; 
        
        for(int i = 2; i <= cost.Length; i++) { 
            memo[i] = Math.Min(memo[i-1] + cost[i-1] , memo[i-2] + cost[i-2]);
        }

        return memo[cost.Length];
    }
}

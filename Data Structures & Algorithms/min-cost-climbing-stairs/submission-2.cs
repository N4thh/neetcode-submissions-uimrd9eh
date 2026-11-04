public class Solution {
    public int MinCostClimbingStairs(int[] cost) {
        if(cost.Length < 2)
            return 0; 
        
        Dictionary<int,int> memo = new Dictionary<int,int>();
        memo[0] = 0; memo[1] = 0;
        
        for(int i = 2; i <= cost.Length; i++) {
            int min1 = memo[i-1] + cost[i-1];
            int min2 = memo[i-2] + cost[i-2];

            memo[i] = Math.Min(min1,min2);
        }

        return memo[cost.Length];    
    }
    
}

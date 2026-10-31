public class Solution {
    private Dictionary<int,int> memo; 
    public int ClimbStairs(int n) {     
        memo = new Dictionary<int,int>(); 
        memo[0] = 1; memo[1] = 1;

        if(n == 0)
            return memo[0];
        
        for(int i = 2; i <= n; i++) { 
            memo[i] = memo[i-1] + memo[i-2];
        }

        return memo[n];
    }
}

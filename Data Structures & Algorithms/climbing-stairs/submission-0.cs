public class Solution {
    public int ClimbStairs(int n) {     
        Dictionary<int,int> memo = new Dictionary<int,int>();
        
        if(n == 0)
            return 1;
        if(memo.ContainsKey(n))
            return memo[n]; 
        
        memo[0] = 1; 
        memo[1] = 1; 
        
        for(int i = 2; i <= n; i++) { 
            memo[i] = memo[i-1] + memo[i-2];
        }

        return memo[n]; 
    }
}

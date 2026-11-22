public class Solution {
    private Dictionary<int,int> dp;
    public int CoinChange(int[] coins, int amount) {
        dp = new Dictionary<int,int>(); 

        int min = dfs(coins, amount);
        return min == int.MaxValue ? -1 : min;
    }
    
    private int dfs(int[] coins, int amount) {
        if(amount == 0) return 0;

        if(dp.ContainsKey(amount)) return dp[amount]; 

        int result = int.MaxValue; 
        foreach(int coin in coins){ 
            if(amount - coin >= 0) { 
                int res = dfs(coins, amount - coin);

                if(res != int.MaxValue){
                    result = Math.Min(result, res + 1);
                }
            }
        }

        dp[amount] = result;
        return result; 
    }
}

public class Solution {
    public Dictionary<int,int>memo;
    public int CoinChange(int[] coins, int amount) {
        memo = new Dictionary<int,int>();

        int min = dfs(amount, coins);
        return min == int.MaxValue ? -1 : min;
    }
    public int dfs(int amount, int[] coins){
        if(amount == 0)
            return 0; 
        if(memo.ContainsKey(amount))
            return memo[amount]; 

        int res = int.MaxValue;
        foreach(int coin in coins){
            if(amount - coin >= 0) {
                int result = dfs(amount - coin, coins);
                if(result != int.MaxValue){
                    res = Math.Min(res, result + 1);
                }
            }
        }

        memo[amount] = res;
        return res;
    }
}

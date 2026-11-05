public class Solution {
    private Dictionary<(int, bool),int> memo;
    public int MaxProfit(int[] prices) {
        memo = new Dictionary<(int,bool),int>();  
        if(prices.Length == 1) return 0;
        
        return dfs(0, prices, false);
    }

    private int buyPriceAtTime = 0; 
    private int dfs(int i, int[] prices, bool isBuy){
        if(i >= prices.Length) return 0;

        var key = (i, isBuy);
        if(memo.ContainsKey(key)) return memo[key];
        
        int coolDown = dfs(i+1, prices, isBuy);
        if(!isBuy){ 
            int buy = dfs(i+1,prices, true) - prices[i];
            return memo[key] = Math.Max(buy, coolDown);
        } else{
            int sell = dfs(i+2, prices, false) + prices[i];
            return memo[key] = Math.Max(sell, coolDown);
        }

        return memo[key];
    }
}
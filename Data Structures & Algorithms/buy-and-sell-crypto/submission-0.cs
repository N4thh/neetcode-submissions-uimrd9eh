public class Solution {
    public int MaxProfit(int[] prices) {
        int sell = 0, buy = 0, profit = 0; 
        for(int i = 0; i < prices.Length; i++){ 
            if(prices[i] < prices[buy]){ 
                buy = i; 
                sell = i;
            }
            if(prices[i] > prices[sell]){
                sell = i;
            }
            int result = prices[sell] - prices[buy];
            profit = Math.Max(profit, result);
        }
        return profit;
    }
}
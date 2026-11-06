public class Solution {
    public int Change(int amount, int[] coins) {
        int n = coins.Length;
        int[,] memo = new int[n + 1, amount +1]; 

        Array.Sort(coins);
        for(int i = 0; i < n; i++){
            memo[i,0] = 1;
        }
        
        for(int i = n - 1; i >= 0; i--){
            for(int j = 0; j <= amount; j++) {
                if(j >= coins[i]){
                    memo[i,j] = memo[i+1, j];
                    memo[i,j] += memo[i, j - coins[i]];
                }
            }
        }

        return memo[0, amount];
    }
}

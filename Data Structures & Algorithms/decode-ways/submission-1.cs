public class Solution {
    private Dictionary<int,int> dp; 
    public int NumDecodings(string s) {
        dp = new Dictionary<int,int>();
        dp[s.Length] = 1;

        return dfs(0, s);
    }
    
    private int dfs(int i, string s){
        if(dp.ContainsKey(i))
            return dp[i];

        if(s[i] == '0') return 0; 

        int result = dfs(i+1, s);

        if(i + 1 < s.Length && (s[i] == '1' || s[i] == '2' && s[i+1] <= '6')) { 
            result += dfs(i+2, s);
        }

        dp[i] = result;
        return result;
    }
}

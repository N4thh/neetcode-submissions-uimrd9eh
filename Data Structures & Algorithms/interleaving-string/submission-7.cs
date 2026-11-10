public class Solution {
    private Dictionary<(int,int), bool> dp;
    public bool IsInterleave(string s1, string s2, string s3) {
        dp = new Dictionary<(int,int), bool>();
        
        if(s1.Length + s2.Length != s3.Length)
            return false;
        
        return dfs(0, 0, 0, s1, s2, s3);
    }

    private bool dfs(int i, int j, int k, string s1, string s2, string s3){
        if(k == s3.Length) return true;

        var key = (i, j);
        if(dp.ContainsKey(key))
            return dp[key];
        
        
        if(i < s1.Length && s1[i] == s3[k] ){
            if(dfs(i+1, j, k+1, s1, s2, s3))
                return dp[key] = true;
        } 
        
        if (j < s2.Length && s2[j] == s3[k]) {
            if(dfs(i, j+1, k+1, s1, s2, s3))
                return dp[key] = true;
        }

        return dp[key] = false;
    }
}

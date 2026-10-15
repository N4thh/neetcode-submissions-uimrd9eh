public class Solution {
    public Dictionary<int,int>memo;
    public int NumDecodings(string s) {
        memo = new Dictionary<int,int>();

        memo[s.Length] = 1;
        return dfs(0, s);
    }

    public int dfs(int i, string s) { 
        if(memo.ContainsKey(i))
            return memo[i];
        if(s[i] == '0')
            return 0;
        
        int res = dfs(i+1,s);

        if(i + 1 < s.Length && 
        (s[i] == '1' || s[i] == '2' && s[i+1] <= '6')) {
            res += dfs(i+2,s);
        }

        memo[i] = res;
        return res;
    }
}

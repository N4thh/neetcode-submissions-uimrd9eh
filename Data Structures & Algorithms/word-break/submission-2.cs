public class Solution {
    public Dictionary<int,bool> memo;

    public bool WordBreak(string s, List<string> wordDict) {
        memo = new Dictionary<int,bool>{ {s.Length, true} };
        return dfs(s, wordDict, 0);
    }
    private bool dfs(string s, List<string> wordDict, int start) { 
        if(memo.ContainsKey(start))
            return memo[start];
        
        foreach(string w in wordDict) { 
            if(start + w.Length <= s.Length && s.Substring(start, w.Length) == w) { 
                if(dfs(s, wordDict, start + w.Length)) {
                    memo[start] = true; 
                    return true;
                }
            }
        }
        
        memo[start] = false; 
        return false;
    }
}

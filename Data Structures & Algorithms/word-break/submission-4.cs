public class Solution {
    private Dictionary<int,bool> memo; 
    public bool WordBreak(string s, List<string> wordDict) {
        memo = new Dictionary<int,bool>(); 
        memo[s.Length] = true; 

        return dfs(0, s, wordDict);
    }
    
    private bool dfs(int i, string s, List<string> wordDict){
        if(i == s.Length)
            return memo[i];
        if(memo.ContainsKey(i))
            return memo[i];
        
        foreach(string word in wordDict) { 
            if(i + word.Length <= s.Length && s.Substring(i, word.Length) == word) { 
                if(dfs(i + word.Length, s, wordDict)) { 
                    memo[i] = true; 
                    return true;
                }
            } 
        }
        memo[i] = false; 
        return false;
    }
}

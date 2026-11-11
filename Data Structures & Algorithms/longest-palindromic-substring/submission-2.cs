public class Solution {
    private Dictionary<(int,int), bool> dp;
    public string LongestPalindrome(string s) {
        dp = new Dictionary<(int,int), bool>();
        if(s.Length <= 2) return s;
        
        int start = 0, maxLength = 1;
        
        for(int i = s.Length - 1; i >= 0; i--) { 
            for(int j = i; j < s.Length; j++) {
                if(s[i] == s[j]) {
                    if(j - i <= 2) {
                        dp[(i,j)] = true;
                    } else {
                        dp[(i,j)] = dp[(i+1, j-1)];
                    }
                } else dp[(i,j)] = false;

                if(dp[(i,j)] && j - i + 1 > maxLength) {
                    start = i;
                    maxLength = j - i + 1;
                }
            }
        }

        return s.Substring(start, maxLength);
    }
}

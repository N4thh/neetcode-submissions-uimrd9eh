public class Solution {
    public string LongestPalindrome(string s) {
        int n = s.Length;
        bool[,] dp = new bool[n,n]; 

        int start = 0, maxLen = 1;
        
        for(int i = n -1; i >= 0; i--) { 
            for (int j = i; j < n; j++) { 
                if(s[i] == s[j]) {
                    if(j - i <= 2) { 
                        dp[i,j] = true;
                    } else { 
                        dp[i,j] = dp[i + 1, j - 1];
                    }
                }

                if(dp[i,j] && j - i + 1 > maxLen) { 
                    start = i;
                    maxLen = j - i + 1;
                }
            }
        }

        return s.Substring(start, maxLen);
    }
}

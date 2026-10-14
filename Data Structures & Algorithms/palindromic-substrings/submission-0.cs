public class Solution {
    public int CountSubstrings(string s) {
        int n = s.Length; 
        bool[,] dp = new bool[n,n]; 

        int rs = 0;

        for(int i = n - 1; i >= 0; i--) { 
            for(int j = i; j < n; j++) {
                if(s[i] == s[j]) { 
                    if(j - i <= 2) { 
                        dp[i,j] = true;
                    }
                    else {
                        dp[i,j] = dp[i+1, j-1];
                    }
                }

                if(dp[i,j])
                    rs++;
            }
        }
        return rs;
    }
}

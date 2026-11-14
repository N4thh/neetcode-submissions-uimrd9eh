public class Solution {
    public int CountSubstrings(string s) {
        int n = s.Length;
        bool[,] memo = new bool[n,n]; 

        int count = 0;
        for(int i = n - 1; i >= 0; i--){
            for(int j = i; j < n; j++) { 
                if(s[i] == s[j]) {
                    if(j - i <= 2){
                        memo[i,j] = true;
                    }
                    else { memo[i,j] = memo[i+1, j-1]; }
                }
    
                if(memo[i,j])
                    count++;
            }
        }
        return count;
    }
}

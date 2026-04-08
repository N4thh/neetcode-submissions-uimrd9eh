public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<int> substring = new HashSet<int>();
        int longest =0, left =0; 
        for(int right=0 ;right < s.Length; right ++){ 
            while(substring.Contains(s[right])){
                substring.Remove(s[left]);
                left++; 
            }
            substring.Add(s[right]);
            longest = Math.Max(longest, right - left + 1);
        }
        return longest;
    }
}
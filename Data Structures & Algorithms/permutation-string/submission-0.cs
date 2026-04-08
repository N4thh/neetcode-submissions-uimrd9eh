public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int [] arr = new int [26];

        if(s1.Length > s2.Length) return false; 
        foreach(var c in s1){ 
            arr[c - 'a']++;
        }

        int left = 0, right = 0; 

        while(right < s2.Length){ 
            int curIndex = s2[right];
            arr[curIndex - 'a']--; 

            while(arr[curIndex -'a'] < 0){ 
                arr[s2[left] -'a']++; 
                left++;
            }

            right++; 
            if(right - left == s1.Length){ 
                return true;
            }
        }
        return false;
    }
}

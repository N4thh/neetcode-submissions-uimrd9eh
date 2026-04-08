public class Solution {
    public bool hasDuplicate(int[] nums) {
        var count = new Dictionary <int,int>();
        if(nums.Length ==0 || nums.Length ==1) return false;
        foreach(int c in nums)
        { 
            if(count.ContainsKey(c)) {count[c]++; return true;}
            else {count[c] = 1;}
        }
        return false;
    }
}
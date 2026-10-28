public class Solution {
    public bool CanPartition(int[] nums) {
        int sum = nums.Sum(); 
        if(sum % 2 != 0)
            return false; 
        
        int target = sum / 2;

        HashSet<int> dp = new HashSet<int>();
        dp.Add(0); 
        for(int i = nums.Length - 1; i >= 0; i--) {
            HashSet<int> dummy = new HashSet<int>();
            foreach(int t in dp){
                if(t + nums[i] == target)
                    return true;
                if(t + nums[i] < target)
                    dummy.Add(t + nums[i]);
                dummy.Add(t);
            }
            dp = dummy;
        }
        return false;
    }
}

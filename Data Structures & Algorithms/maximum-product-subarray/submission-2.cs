public class Solution {
    public int MaxProduct(int[] nums) {
        if(nums.Length == 1)
            return nums[0];
        int max = nums[0], min = nums[0], result = nums[0];
        
        for(int i = 1; i < nums.Length; i++) { 
            if(nums[i] < 0) {
                int temp = min;
                min = Math.Min(max * nums[i], nums[i]);
                max = Math.Max(temp * nums[i], nums[i]);
            } else {
                min = Math.Min(min * nums[i], nums[i]);
                max = Math.Max(max * nums[i], nums[i]);
            }

            result = Math.Max(result,max); 
        }
        return result;
    }
}
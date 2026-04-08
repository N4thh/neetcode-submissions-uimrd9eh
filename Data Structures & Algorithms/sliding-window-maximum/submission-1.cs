public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums.Length == 1) return nums;

        List<int> result = new List<int>();
        int right = 0, left =0;
        int max = int.MinValue;

        while(right < nums.Length){ 
            if(right - left + 1 == k){ 
               for(int i = left; i < right + 1 ; i++){
                    max = Math.Max(max, nums[i]);
               }
                result.Add(max);
                left++;
                max = int.MinValue; 
            }
            right++; 
        }
        return result.ToArray();
    }
}

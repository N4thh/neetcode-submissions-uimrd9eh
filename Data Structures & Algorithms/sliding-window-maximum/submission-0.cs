public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums.Length == 1) return nums;

        List<int> result = new List<int>();

        for (int i = 0; i <= nums.Length - k; i++) {
            int max = nums[i];
            for (int j = i; j < i + k; j++) {
                max = Math.Max(max, nums[j]);
            }
            result.Add(max);
        }

        return result.ToArray();
    }
}

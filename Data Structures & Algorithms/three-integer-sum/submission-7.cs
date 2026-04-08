public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        if (nums.Length < 3) return result;

        Array.Sort(nums);       
        int n = nums.Length;

        int i = 0;
        while (i < n - 2) { // i chạy từ 0 đến n-3
            int j = i + 1;
            int k = n - 1;

            while (j < k) {
                int sum = nums[i] + nums[j] + nums[k];
                
                if (sum < 0) {
                    j++;
                } else if (sum > 0) {
                    k--;
                } else { // sum == 0
                    result.Add(new List<int> { nums[i], nums[j], nums[k] });
                    
                    // skip duplicate nums[j] và nums[k]
                    while (j < k && nums[j] == nums[j + 1]) j++;
                    while (j < k && nums[k] == nums[k - 1]) k--;
                    
                    j++;
                    k--;
                }
            }

            // skip duplicate nums[i]
            int current = nums[i];
            while (i < n - 2 && nums[i] == current) i++;
        }

        return result;
    }
}

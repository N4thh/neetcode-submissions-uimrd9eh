public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        if(nums.Length < 3) return result;
        Array.Sort(nums);       
        int n = nums.Length, i = 0;
        while (i < n - 2)
        {
            int j = i+1, k = n-1; 
            while ( j < k)
            { 
                int sum = nums[i] + nums[j] + nums[k];
                if (sum == 0) {
                    result.Add(new List<int> { nums[i], nums[j], nums[k] });              
                    while (j <k  && nums[j] == nums[j+1]) j++; 
                    while (j <k  && nums[k] == nums[k-1]) k--; 
                    j++;
                    k--; 
                }
                else if(sum < 0) {                     
                j++;
                }
                else k--;
                          
            } 
            int current = nums[i];
            while (i < j && nums[i] == current) i++; 
        }
        return result;
    }
}

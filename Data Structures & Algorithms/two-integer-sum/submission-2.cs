public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> memo = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++) {
            int remaining = target - nums[i]; 

            if(memo.ContainsKey(remaining)){
                return new int [] {memo[remaining], i};
            }

            memo[nums[i]] = i;
        }

        return new int [] {};
    }
}

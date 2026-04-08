public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        List<int> subnet = new List<int>();

        void dfs(int i, int start) {
            if(i >= nums.Length) {
                res.Add(new List<int>(subnet));
                return;
            }

            if(i > start && nums[i] == nums[i-1]) {
                dfs(i+1, i);
            }

            subnet.Add(nums[i]);
            dfs(i+1, i);
            subnet.RemoveAt(subnet.Count -1);
            dfs(i+1, i);
        }
        dfs(0,0);
        return res;
    }
}

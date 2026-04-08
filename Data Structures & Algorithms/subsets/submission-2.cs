public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        List<int> subnet = new List<int>();

        void dfs(int i) {
            if(i >= nums.Length) {
                res.Add(new List<int>(subnet));
                return;
            }

            subnet.Add(nums[i]);
            dfs(i+1);
            subnet.RemoveAt(subnet.Count -1);
            dfs(i+1);
        }
        dfs(0);
        return res;
    }
}

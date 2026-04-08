public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> res = new List<List<int>>();
        List<int> subnet = new List<int>();

        void dfs(int start) {
            res.Add(new List<int>(subnet)); 

            for(int i = start; i < nums.Length; i++) { 
                subnet.Add(nums[i]);
                dfs(i+1); 
                subnet.RemoveAt(subnet.Count -1);
            }
        }
        dfs(0);
        return res;
    }
}

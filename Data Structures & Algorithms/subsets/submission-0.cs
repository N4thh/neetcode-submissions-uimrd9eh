public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        List<List<int>> res = new List<List<int>>();       
         if(nums.Length == 0)
            return res;

        res.Add(new List<int>());
                    
        foreach(int num in nums) {
            int size = res.Count;

            for(int i =0; i < size; i++) {
                List<int> temp = new List<int>(res[i]);
                temp.Add(num);
                res.Add(temp);
            }
        }
        return res;
    }
}

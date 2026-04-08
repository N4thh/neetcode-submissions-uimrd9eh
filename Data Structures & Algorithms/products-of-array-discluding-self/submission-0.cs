
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {

        var Dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int product = 1;        
            for (int j = 0; j < nums.Length; j++) {
                if (i == j) continue; 
                product *= nums[j];
            }                    
            Dic[i] = product;
        }
        return Dic.Values.ToArray();
    }
}

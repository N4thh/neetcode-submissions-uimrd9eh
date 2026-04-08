public class Solution {
     public int[] TwoSum(int[] nums, int target)
 {
     for (int j = 0; j < nums.Length - 1; j++)
     {
         for(int i = j+1;  i < nums.Length; i++)
         {
             if (nums[j] + nums[i] == target)
             {
                 return new int[] {j,i };
             }
         }
     }
     return null; 
     
 }
}
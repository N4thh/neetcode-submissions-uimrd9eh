public class Solution {
     public int[] TwoSum(int[] nums, int target)
 {
    var dic = new Dictionary <int,int> ();
    for(int i = 0 ; i < nums.Length ; i++)
    {
        int last = target - nums[i];
        if(!dic.ContainsKey(last)) dic.Add(nums[i], i);
        else {return new int[] { dic[last], i };}
    }
    return new int [] {} ; 
 }
}
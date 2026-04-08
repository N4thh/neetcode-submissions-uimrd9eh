public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
    var count = new Dictionary <int,int>(); 
    foreach(int c in nums)
    {
        if(count.ContainsKey(c)) {count[c]++;} 
        else {count[c]=1; }
    }
    var sorted = count.OrderByDescending(pair => pair.Value).Take(k).Select(pair => pair.Key).ToArray();
    return sorted;
}
}
public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach(var c  in nums) { 
            pq.Enqueue(c, -c);
        }
        int count = 0;
        int res = int.MinValue; 

        while(count < k) {
            int temp = pq.Dequeue();
            if(count == k-1){
                res = temp;
            }
            count ++;            
        }
        return res;
    }
}

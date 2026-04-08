public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach(var c  in nums) { 
            pq.Enqueue(c, -c);
        }
        int count = 0;

        while(count < k - 1) {
            int temp = pq.Dequeue();
            count ++;            
        }
        return pq.Peek();
    }
}

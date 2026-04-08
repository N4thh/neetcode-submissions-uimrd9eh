public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> pq = new PriorityQueue<int,int>(); 

        for(int i = 0; i < stones.Length; i++) { 
            pq.Enqueue(stones[i], -stones[i]);
        }

    
        while(pq.Count > 1) { 
            int temp1 = pq.Dequeue();
            int temp2 = pq.Dequeue();

            int temp3 = temp1 - temp2;
            pq.Enqueue(temp3, - temp3);
        }
        return pq.Dequeue();
    }
}

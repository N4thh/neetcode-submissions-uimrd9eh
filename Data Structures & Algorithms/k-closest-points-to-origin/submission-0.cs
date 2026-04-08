public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        int[][] res = new int[k][];
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        Dictionary<int, List<int[]>> map = new Dictionary<int, List<int[]>>();

        for(int i = 0; i < points.Length; i++) {
            int temp = 0; 
            for(int j = 0; j < points[i].Length; j++){ 
                temp += points[i][j] * points[i][j];
            }
            pq.Enqueue(temp, temp); 

            if(!map.ContainsKey(temp)) {
                map[temp] = new List<int[]>();
            }
            map[temp].Add(points[i]);
        }

        for(int i = 0; i < k; i++) {
            int temp = pq.Dequeue();
            res[i] = map[temp][0];
            map[temp].RemoveAt(0);
        }
        return res;
    }
}

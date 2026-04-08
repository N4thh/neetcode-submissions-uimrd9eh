public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] count = new int [26]; 
        foreach(var task in tasks) { 
            count[task - 'A']++; 
        }

        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
        foreach(var c in count ){ 
            if(c > 0)
                pq.Enqueue(c, -c);
        }

        int time = 0; 
        while(pq.Count > 0) { 
            List<int> temp = new List<int>(); 

            for(int i = 0; i < n+1; i++) { 
                if(pq.Count > 0) {
                    int dummy = pq.Dequeue(); 
                    if(dummy - 1 > 0) { 
                    temp.Add(dummy - 1); 
                    }
                    time++;
                }
                else{ 
                    if(temp.Count > 0) { 
                        time++; 
                    }
                }
            }
            foreach(var c in temp) { 
                pq.Enqueue(c, -c);
            }
        }
        return time; 
    }
}

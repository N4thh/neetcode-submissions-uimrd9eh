public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] arr = new int[26]; 
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>(); 

        foreach(var task in tasks) { 
            arr[task - 'A']++;
        }
        for(int i = 0; i < arr.Length; i++) { 
            if(arr[i] == 0)
                continue; 
            pq.Enqueue(arr[i], -arr[i]); 
        }

        int res = 0;
        while(pq.Count > 0) { 
            List<int> temp = new List<int>(); 
            for(int i = 0; i <= n; i++) {
                if(pq.Count > 0) { 
                    int dummy = pq.Dequeue();
                    if(dummy - 1 > 0) { 
                        temp.Add(dummy-1);
                    }
                }
                res++;   
               if(pq.Count == 0 && temp.Count == 0)
                    break;
            }
            foreach(var c in temp) { 
                if(c > 0) 
                    pq.Enqueue(c, -c);
            }
        }
        return res;
    }
}

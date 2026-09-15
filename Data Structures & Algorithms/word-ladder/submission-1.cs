public class Solution {
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        if(!wordList.Contains(endWord) || beginWord == endWord)
            return 0; 

        int n = wordList.Count(); 
        int m = beginWord.Length;
        List<List<int>> adj = new List<List<int>>(n);

        for(int i =0; i < n; i++) { 
            adj.Add(new List<int>());
        }
        
        Dictionary<string, int>graph = new Dictionary<string, int>();
        for(int i = 0; i < n; i++) {
            graph[wordList[i]] = i;
        }
        
        for(int i=0; i < n; i++) { 
            for(int j = i+1; j < n; j++) {
                int cp =0; 
                for(int k =0; k < m; k++) { 
                    char cleft = wordList[i][k];
                    char cright = wordList[j][k];

                    if(cleft != cright)
                        cp ++;
                }
                
                if(cp == 1) { 
                    adj[i].Add(j);
                    adj[j].Add(i);
                }         
            }
        }
        
        HashSet<int>visited = new HashSet<int>(); 
        Queue<int> q = new Queue<int>();

        for(int i = 0; i < m ; i++) { 
            for(char c = 'a'; c <= 'z'; c++) { 
                if(c == beginWord[i])
                    continue; 
                
                string word = beginWord.Substring(0,i) + c + beginWord.Substring(i+1);
                if(graph.ContainsKey(word) && !visited.Contains(graph[word])) { 
                    visited.Add(graph[word]);
                    q.Enqueue(graph[word]);
                }
            }
        }

        int rs = 1;
        while(q.Count > 0) {
            rs++ ;
            int size = q.Count;

            for(int i = 0; i < size; i++) { 
                int node = q.Dequeue(); 

                if(wordList[node] == endWord)
                    return rs;
                
                foreach(var nei in adj[node]) {
                    if(!visited.Contains(nei)) {
                        visited.Add(nei);
                        q.Enqueue(nei);
                    }
                }
            }
        }

        return 0;

    }
}

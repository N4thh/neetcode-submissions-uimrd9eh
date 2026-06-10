public class Solution {
    public int OrangesRotting(int[][] grid) {
        Queue<(int,int)> q = new Queue<(int,int)>();
        int rows = grid.Length; 
        int cols = grid[0].Length; 
        int fresh = 0, minutes = 0;
                
        for(int i = 0; i < rows ; i++) {
            for(int j = 0; j < cols; j++) { 
                if(grid[i][j] == 1)
                    fresh++; 
                if(grid[i][j] == 2) 
                    q.Enqueue((i,j)); 
            }
        }

        if(fresh == 0)
            return 0; 
        if(q.Count == 0) 
            return -1;
        
        int[] dx = {0,0,-1,1};
        int[] dy = {-1,1,0,0};

        while(q.Count > 0) { 
            int size = q.Count;
            bool rotten = false; 

            while(size > 0) { 
                var(r,c) = q.Dequeue(); 
                size--; 
                
                for(int d = 0; d < 4; d++) { 
                    int nr = r + dx[d];
                    int nc = c + dy[d];

                    if(nr < 0 || nc < 0 || nr >= rows || nc >= cols) 
                        continue; 
                    if(grid[nr][nc] != 1) 
                        continue; 
                    
                    q.Enqueue((nr,nc));
                    grid[nr][nc] = 2;
                    fresh --;
                    rotten = true; 
                }
            }
            if(rotten)
                minutes++;
        }

        if(fresh > 0)
            return -1;
        return minutes; 

    }
}

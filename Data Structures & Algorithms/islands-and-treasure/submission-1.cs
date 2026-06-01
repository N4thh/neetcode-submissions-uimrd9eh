public class Solution {
    public void islandsAndTreasure(int[][] grid) {
        Queue<(int, int)> q= new Queue<(int, int)>(); 
        
        int rows = grid.Length;
        int cols = grid[0].Length;
        for(int i = 0; i < rows; i++) { 
            for(int j =0; j < cols; j++) { 
                if(grid[i][j] == 0) { 
                    q.Enqueue((i,j));
                }
            }
        }

        int[] dx = {0,0,-1,1};
        int[] dy = {-1,1,0,0};

        while(q.Count > 0) {
            var (r, c) =  q.Dequeue(); 
            for(int d = 0; d < 4; d++) { 
                int nr = r + dx[d];
                int nc = c + dy[d];

                if(nr < 0 || nc < 0 || nr >= rows || nc >= cols)
                    continue; 
                if(grid[nr][nc] != 2147483647)
                    continue; 
                
                grid[nr][nc] = grid[r][c] + 1;
                q.Enqueue((nr,nc));
            }
        }
    }
}

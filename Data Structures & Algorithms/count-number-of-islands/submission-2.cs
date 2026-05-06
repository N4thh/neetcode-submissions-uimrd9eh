public class Solution {
    public int NumIslands(char[][] grid) {
        int rows = grid.Length; 
        int columns = grid[0].Length; 
        bool[,] visited = new bool[rows, columns];
        int count = 0;

        for(int i = 0; i < rows; i++) { 
            for(int j =0; j < columns; j++) { 
                if(grid[i][j] == '1' && !visited[i,j]) { 
                    count++;
                    dfs(i, j, grid, visited);
                }
            }
        }
        
        return count;
    }

    private void dfs(int r, int c, char[][] grid, bool[,] visited) { 
        int rows = visited.GetLength(0);
        int columns = visited.GetLength(1);

        if(r < 0 || c < 0 || r >= rows || c >= columns) return;
        if(grid[r][c] == '0' || visited[r,c]) return; 
        
        visited[r, c] = true;

        int[] dx = {0,0,1,-1};
        int[] dy = {1,-1,0,0};
        
        for(int d = 0; d < 4; d++) { 
            int nx = r + dx[d];
            int ny = c + dy[d];

            dfs(nx, ny, grid, visited);
        }
    }
}

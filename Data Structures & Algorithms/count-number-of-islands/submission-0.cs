public class Solution {
    public int NumIslands(char[][] grid) {
        int n = grid.Length;
        int m = grid[0].Length; 

        bool[][] visited = new bool[n][];
        for(int i =0; i < n; i++) { 
            visited[i] = new bool[m]; 
        }
        int count = 0; 
        for(int i = 0; i < n ; i++) { 
            for(int j = 0; j < m; j++) { 
                if(grid[i][j] == '1' && !visited[i][j]) {
                    count++;
                    dfs(i,j,grid, visited);
                }
            }
        }
        return count;
    }
    private void dfs(int n, int m, char[][] grid, bool[][] visited) { 
        int rows = grid.Length;
        int columns = grid[0].Length; 
        
        if(n < 0 || m < 0 || n >= rows || m >= columns) return;
        if(visited[n][m] || grid[n][m] == '0') return; 

        visited[n][m] = true; 

        int[] dx = {0,0,1,-1};
        int[] dy = {1,-1,0,0};
        for(int d = 0; d < 4; d++) {
            int nx = n + dx[d], ny = m + dy[d]; 
            if(nx > 0 || ny > 0 || nx < rows || ny < columns) { 
                dfs(nx, ny, grid, visited); 
            }
        }
    }
}

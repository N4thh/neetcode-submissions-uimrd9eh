public class Solution {
    public int MaxAreaOfIsland(int[][] grid) {
        int rows = grid.Length; 
        int columns = grid[0].Length; 
        bool[,] visited = new bool[rows, columns];
        int maxArea = 0; 

        for(int i = 0; i < rows; i++) { 
            for(int j =0; j < columns; j++) { 
                if(grid[i][j] == 1 && !visited[i,j]) { 
                    maxArea = Math.Max(maxArea, dfs(i, j, grid, visited));
                }
            }
        }
        return maxArea;
        
    }

    private int dfs(int r, int c, int[][] grid, bool[,] visited) { 
        int rows = visited.GetLength(0);
        int columns = visited.GetLength(1);

        if(r < 0 || c < 0 || r >= rows || c >= columns) return 0;
        if(grid[r][c] == 0 || visited[r,c]) return 0; 
        
        visited[r, c] = true;
        int area = 1; 

        int[] dx = {0,0,1,-1};
        int[] dy = {1,-1,0,0};
        
        for(int d = 0; d < 4; d++) { 
            int nx = r + dx[d];
            int ny = c + dy[d];

            area += dfs(nx, ny, grid, visited);
        }
        return area; 
    }
}

public class Solution {
    private int rows; 
    private int cols; 
    private int[][] heights; 

    public List<List<int>> PacificAtlantic(int[][] heights) {
        this.heights = heights;
        rows = heights.Length; 
        cols = heights[0].Length;

        bool[,] pacific = new bool[rows, cols];
        bool[,] atlantic = new bool[rows, cols];

        for(int col = 0; col < cols; col++) 
            dfs(0, col, pacific); 
        for(int row = 0; row < rows; row++)
            dfs(row, 0, pacific); 

        for(int col = 0; col < cols; col++) 
            dfs(rows -1 , col, atlantic); 
        for(int row = 0; row < rows; row++)
            dfs(row, cols -1 , atlantic); 
        
        List<List<int>> res = new List<List<int>>();
        for(int i = 0; i < rows; i++) { 
            for(int j = 0; j < cols; j++) { 
                if(pacific[i, j] && atlantic[i,j])
                    res.Add(new List<int>{i,j});
            }
        }
        return res; 
    }
    private void dfs(int row, int col, bool[,] visited) { 
        if(visited[row, col]) 
            return;
        visited[row, col] = true; 
        
        int[] dx = {0,0,-1,1};
        int[] dy = {-1,1,0,0};

        for(int d = 0; d < 4; d++) { 
            int nr = row + dx[d]; 
            int nc = col + dy[d]; 

            if(nr < 0 || nc < 0 || nr >= rows || nc >= cols) 
                continue; 
            if(heights[nr][nc] < heights[row][col])
                continue; 

            dfs(nr, nc, visited); 
        }
    }
}

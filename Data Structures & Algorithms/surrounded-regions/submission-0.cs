public class Solution
{
    private int rows;
    private int cols;
    private char[][] board;

    public void Solve(char[][] board)
    {
        this.board = board;
        rows = board.Length;
        cols = board[0].Length;

        HashSet<(int, int)> visited = new HashSet<(int, int)>();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                List<(int row, int col)> region = new();
                bool touchBorder = false;

                if (board[i][j] == 'O' && !visited.Contains((i, j)))
                {
                    dfs(i, j, visited, region, ref touchBorder);

                    if (!touchBorder)
                    {
                        foreach (var cell in region)
                        {
                            board[cell.row][cell.col] = 'X';
                        }
                    }
                }
            }
        }
    }

    private void dfs(
        int row,
        int col,
        HashSet<(int, int)> visited,
        List<(int row, int col)> region,
        ref bool touchBorder)
    {
        if (visited.Contains((row, col)))
            return;

        visited.Add((row, col));
        region.Add((row, col));

        if (isBorder(row, col))
        {
            touchBorder = true;
        }

        int[] dx = { 0, 0, -1, 1 };
        int[] dy = { -1, 1, 0, 0 };

        for (int d = 0; d < 4; d++)
        {
            int nr = row + dx[d];
            int nc = col + dy[d];

            if (nr < 0 || nc < 0 || nr >= rows || nc >= cols)
                continue;

            if (board[nr][nc] == 'O' &&
                !visited.Contains((nr, nc)))
            {
                dfs(nr, nc, visited, region, ref touchBorder);
            }
        }
    }

    private bool isBorder(int row, int col)
    {
        return row == 0 ||
               row == rows - 1 ||
               col == 0 ||
               col == cols - 1;
    }
}
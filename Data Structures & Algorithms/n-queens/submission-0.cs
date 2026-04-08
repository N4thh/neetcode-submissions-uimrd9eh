public class Solution {
    public List<List<string>> SolveNQueens(int n) {
        List<List<string>> res = new List<List<string>>();
        var board = new char[n][];
        for(int i = 0; i < n; i++) { 
            board[i] = new string('.', n).ToCharArray();
        }
        dfs(board, 0, res);
        return res;
        
    }
    private void dfs(char[][] board, int row, List<List<string>> res) { 
        if(row == board.Length) { 
            var sub = new List<string>(); 
            foreach(var c in board) { 
                sub.Add(new string(c));
            }
            res.Add(sub);
            return;
        }

        for(int col = 0; col < board.Length; col++) {
            if(IsSafe(board, row, col)) { 
                board[row][col] = 'Q'; 
                dfs(board, row + 1, res); 
                board[row][col] = '.'; 
            }
        }
    }
    private bool IsSafe(char[][] board, int row, int col) { 
        for(int i = 0; i < board.Length; i++) { 
            if(board[i][col] == 'Q') 
                return false; 
        }

        for(int i = row -1, j = col - 1; i >=0 && j >=0 ; i--, j--) { 
            if(board[i][j] == 'Q')
                return false;
        }
        //left
        for(int i = row -1, j = col - 1; i >=0 && j >=0 ; i--, j--) { 
            if(board[i][j] == 'Q')
                return false;
        }
        //right 
        for(int i = row - 1, j = col + 1; j < board.Length && i >= 0 ; j++, i--) {
            if(board[i][j] == 'Q')
                return false;
        }
        return true;
    }
}

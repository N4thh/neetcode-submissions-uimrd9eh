public class Solution {
    public bool Exist(char[][] board, string word) {

        for(int i = 0; i < board.Length; i++) { 
            for(int j = 0; j < board[0].Length; j++) { 
                if(dfs(board, i, j , word , word.Length -1 )) 
                    return true;
            }
        }
        return false; 

    }
    public bool dfs(char[][] board, int i , int j, string word,  int index) {           
        if(i < 0 || j < 0 || i >= board.Length || j >= board[0].Length || board[i][j] != word[index])
            return false;

        if(index == 0)
            return true;             

        char c = board[i][j];
        board[i][j] = '#';

        int[] dx = {-1,1,0,0};
        int[] dy = {0,0,-1,1}; 

        for(int d = 0; d < 4; d++) { 
            int ni = i + dx[d], nj = j + dy[d];

            if(ni >= 0 && ni < board.Length && nj >= 0 && nj < board[0].Length) { 
                if(dfs(board, ni, nj, word, index - 1))
                    return true;
            }
        }
        board[i][j] = c; 
        return false;
    }    
}

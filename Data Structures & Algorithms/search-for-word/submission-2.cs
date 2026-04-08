public class Solution {
    public bool Exist(char[][] board, string word) {

        for(int i = 0; i < board.Length; i++) { 
            for(int j = 0; j < board[0].Length; j++) { 
                if(dfs(board, i, j , word , 0)) 
                    return true;
            }
        }
        return false; 
    }

    public bool dfs(char[][] board, int i , int j, string word, int index) { 
        
        if(i < 0 || j < 0 || i >= board.Length || j >= board[0].Length)
            return false;

        if(board[i][j] != word[index])
            return false;

        if(index == word.Length - 1)
            return true;

        char c = board[i][j];
        board[i][j] = '#';

        int[] dx = {-1,1,0,0};
        int[] dy = {0,0,-1,1}; 

        for(int d = 0; d < 4; d++) { 
            if(dfs(board, i + dx[d], j + dy[d], word, index + 1))
                return true;
        }

        board[i][j] = c; 
        return false;
    }    
}
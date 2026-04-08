public class TrieNode { 
    public Dictionary<char, TrieNode> Children = new Dictionary<char,TrieNode>(); 
    public string Word = null;
}
public class Solution {
     TrieNode root = new TrieNode(); 

    public List<string> FindWords(char[][] board, string[] words) {
        BuildTree(words); 
        List<string> result = new List<string>();

        int m = board.Length , n = board[0].Length; 
        for(int i = 0; i < m ; i++) { 
            for(int j =0; j < n; j++){ 
                DFS(board, i , j, root, result);
            }
        }
        
        return result; 
    }
    
    public void BuildTree(string[] words) { 
        foreach(var word in words) { 
            TrieNode node = root;
            foreach(var c in word) { 
                if(!node.Children.ContainsKey(c))
                    node.Children[c] = new TrieNode();
                node = node.Children[c];
            }
            node.Word = word; 
        }
    }

    public void DFS(char[][] board, int i, int j, TrieNode node, List<string> result) {
        char c = board[i][j]; 

        if(c == '#' || !node.Children.ContainsKey(c)){
            return;
        }

        node = node.Children[c]; 

        if(node.Word != null) { 
            result.Add(node.Word); 
            node.Word = null; 
        }

        board[i][j] = '#';
        
        int[] dx = {-1,1,0,0};
        int[] dy = {0,0,-1,1};
        for(int d = 0; d < 4; d++) { 
            int ni = i + dx[d], nj = j + dy[d];
            
            if(ni >= 0 && ni < board.Length && nj >=0 && nj < board[0].Length) { 
                DFS(board, ni, nj, node, result);
            }
        }
        board[i][j] = c; 
    }
}

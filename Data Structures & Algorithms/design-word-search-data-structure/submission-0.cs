public  class TrieNode { 
    public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
    public bool IsEndOfWord = false;
}
public class WordDictionary {
    private TrieNode root;

    public WordDictionary() {
        root = new TrieNode();    
    }
    
    public void AddWord(string word) {
        TrieNode node = root; 

        foreach(char c in word) { 
            if(!node.Children.ContainsKey(c))
                node.Children[c] = new TrieNode();

            node = node.Children[c];
        }
        node.IsEndOfWord = true; 
    }
    private int i; 
    public bool Search(string word) {
        TrieNode node = root;
        i = 0;
        
        return DFS(word, i , node);
    }
    public bool DFS(string word, int i, TrieNode node) { 
        if(word.Length == i) 
            return node.IsEndOfWord; 

        char c = word[i]; 
        if(c == '.') {
            foreach(var child in node.Children.Values) { 
                if(DFS(word, i +1, child))
                    return true; 
            }
            return false; 
        }

        if(!node.Children.ContainsKey(c))
            return false;
        
        return DFS(word, i + 1, node.Children[c]);
    }
    
}

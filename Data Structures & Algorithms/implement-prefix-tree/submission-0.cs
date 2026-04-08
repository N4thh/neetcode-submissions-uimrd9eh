public class TrieNode { 
    public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>(); 
    public bool IsEndOfWord = false; 
}

public class PrefixTree {
  
    private TrieNode root;

    public PrefixTree() {
       root = new TrieNode();
    }
    
    public void Insert(string word) {
        TrieNode node = root; 

        foreach(char c in word) { 
            if(!node.Children.ContainsKey(c)) { 
                node.Children[c] = new TrieNode(); 
            }
            node = node.Children[c];
        }
        node.IsEndOfWord = true; 
    }
    
    public bool Search(string word) {
        TrieNode node = root; 

        foreach(char c in word) { 
            if(!node.Children.ContainsKey(c)) { 
                return false;
            }
            node = node.Children[c];
        }

        return node.IsEndOfWord;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode node = root; 

        foreach(char c in prefix) { 
            if(!node.Children.ContainsKey(c)) { 
                return false;
            }
            node = node.Children[c];
        }
        return true;
    }
}

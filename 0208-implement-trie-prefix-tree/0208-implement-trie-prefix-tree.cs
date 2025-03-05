public class Trie {
    public class TrieNode{
        public Dictionary<char,TrieNode> children = new ();
        public bool word;
    }
    private TrieNode root;
    public Trie() {
        root = new();
    }
    
    public void Insert(string word) {
        TrieNode current = root;
        foreach(var ch in word){
            if(!current.children.ContainsKey(ch)){
                current.children[ch]=new TrieNode();
            }
            current = current.children[ch];
        }
        current.word=true;
    }
    
    public bool Search(string word) {
        TrieNode current = root;
        foreach(var ch in word){
            if(!current.children.ContainsKey(ch)){
                return false;
            }
            current=current.children[ch];
        }
        return current.word;
    }
    
    public bool StartsWith(string prefix) {
        TrieNode current = root;
        foreach(var ch in prefix){
            if(!current.children.ContainsKey(ch)){
                return false;
            }
            current=current.children[ch];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */
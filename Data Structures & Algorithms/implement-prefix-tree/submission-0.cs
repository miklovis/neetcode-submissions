public class PrefixTree {

    HashSet<string> dictionary;

    public PrefixTree() {
        this.dictionary = new HashSet<string>();
    }
    
    public void Insert(string word) {
        dictionary.Add(word);
    }
    
    public bool Search(string word) {
        return dictionary.Contains(word);
    }
    
    public bool StartsWith(string prefix) {
        foreach (string word in dictionary) {
            if (word.StartsWith(prefix)) {
                return true;
            }
        }

        return false;
    }
}

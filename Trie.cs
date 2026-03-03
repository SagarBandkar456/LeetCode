class TrieNode
{
    public TrieNode[] child = new TrieNode[26];
    public bool isLeaf;

    public TrieNode()
    {
        isLeaf = false;
        for (int i = 0; i < 26; i++)
        {
            child[i] = null;
        }
    }
}

public class Trie
{
    TrieNode root;

    public Trie() { root = new TrieNode(); }

    public void Insert(string key)
    {
        TrieNode curr = root;

        foreach (char c in key)
        {
            if (curr.child[c - 'a'] == null)
            {
                curr.child[c - 'a'] = new TrieNode();
            }

            curr = curr.child[c - 'a'];
        }
        curr.isLeaf = true;
    }

    public bool Search(string key)
    {
        TrieNode curr = root;

        foreach (char c in key)
        {
            if (curr.child[c - 'a'] == null) return false;
            else curr = curr.child[c - 'a'];
        }
        return curr.isLeaf;
    }

    public bool HasAllPrefix(string key)
    {
        TrieNode curr = root;

        foreach (char c in key)
        {
            if (curr.child[c - 'a'] == null) return false;
            else curr = curr.child[c - 'a'];
        }
        return true;
    }
}
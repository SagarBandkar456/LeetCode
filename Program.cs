using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        Trie trie = new Trie();
        string[] arr = { "a", "ap", "app", "appl", "apple", "apply" };
        foreach (string s in arr) { trie.Insert(s); }

        trie.HasAllPrefix("apple");
        Console.ReadLine();
    }
}
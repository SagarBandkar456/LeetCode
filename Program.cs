using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        // Trie trie = new Trie();
        // string[] arr = { "a", "ap", "app", "appl", "apple", "apply" };
        // foreach (string s in arr) { trie.Insert(s); }

        // trie.HasAllPrefix("apple");


        //Dijishtra algorithm
        int[,] graph = new int[,]
            {
                { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
            };

        Dijkstra dijkstra = new Dijkstra();
        dijkstra.Solve(graph, 0);
        Console.ReadLine();
    }
}
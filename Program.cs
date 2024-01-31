using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    static int[,] dp = new int[501, 501];
    static int Solve(int m, int n, string word1, string word2)
    {
        if (m == word1.Length) return word2.Length - n;

        if (n == word2.Length) return word1.Length - m;

        if (dp[m, n] != -1) return dp[m, n];

        int res = 0;
        if (word1[m] == word2[n])
        {
            return dp[m, n] = Solve(m + 1, n + 1, word1, word2);
        }
        else
        {
            //Insert
            int insert = 1 + Solve(m, n + 1, word1, word2);
            //Delete
            int delete = 1 + Solve(m + 1, n, word1, word2);
            //Replace
            int replace = 1 + Solve(m + 1, n + 1, word1, word2);

            res = Math.Min(insert, Math.Min(delete, replace));
        }

        return dp[m, n] = res;
    }
    public static int MinDistance(string word1, string word2)
    {
        return Solve(0, 0, word1, word2);
    }
    public static void Main(string[] args)
    {
        string word1 = "horse", word2 = "ros";

        for (int i = 0; i < 501; i++)
        {
            for (int j = 0; j < 501; j++)
            {
                dp[i, j] = -1;
            }
        }
        Console.WriteLine(MinDistance(word1, word2));
    }
}
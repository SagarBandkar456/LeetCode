using System;

class EditDistance
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
    public int MinDistance(string word1, string word2)
    {
        return Solve(0, 0, word1, word2);
    }
}
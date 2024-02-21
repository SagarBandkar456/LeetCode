using System;

class UniquePath
{
    static int[,] dp = new int[101, 101];
    public int Solve(int x, int y, int m, int n)
    {
        if (x >= m || y >= n) return 0;
        if (x == m - 1 && y == n - 1) return 1;

        if (dp[x, y] != -1) return dp[x, y];
        return dp[x, y] = Solve(x + 1, y, m, n) + Solve(x, y + 1, m, n);
    }
}
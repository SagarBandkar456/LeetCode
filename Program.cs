using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    static int[,] dp = new int[101, 101];
    public static int Solve(int x, int y, int m, int n)
    {
        if (x >= m || y >= n) return 0;
        if (x == m - 1 && y == n - 1) return 1;

        if (dp[x, y] != -1) return dp[x, y];
        return dp[x, y] = Solve(x + 1, y, m, n) + Solve(x, y + 1, m, n);
    }
    public static void Main(string[] args)
    {
        for (int i = 0; i < 101; i++)
        {
            for (int j = 0; j < 101; j++)
            {
                dp[i, j] = -1;
            }
        }
        Console.WriteLine(Solve(0, 0, 3, 7));
    }
}
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    static int[] dp = new int[1001];
    public static int Solve(int[] cost, int n)
    {
        if (dp[n] != -1) return dp[n];
        if (n <= 1) return dp[n] = 0;

        return dp[n] = Math.Min(Solve(cost, n - 1) + cost[n - 1], Solve(cost, n - 2) + cost[n - 2]);
    }
    public static int MinCostClimbingStairs(int[] cost)
    {

        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = -1;
        }
        return Solve(cost, cost.Length);
    }

    public static void Main(string[] args)
    {
        int[] cost = [10, 15, 20]
        MinCostClimbingStairs(cost);
    }
}
using System;

class ClimbingStairs
{
    static int[] dp = new int[1001];
    public int Solve(int[] cost, int n)
    {
        if (dp[n] != -1) return dp[n];
        if (n <= 1) return dp[n] = 0;

        return dp[n] = Math.Min(Solve(cost, n - 1) + cost[n - 1], Solve(cost, n - 2) + cost[n - 2]);
    }
    public int MinCostClimbingStairs(int[] cost)
    {

        for (int i = 0; i < dp.Length; i++)
        {
            dp[i] = -1;
        }
        return Solve(cost, cost.Length);
    }
}
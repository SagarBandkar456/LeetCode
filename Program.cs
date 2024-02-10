using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    static int[] dp = new int[401];
    static int Solve(int[] nums, int n)
    {
        if (n == 0)
        {
            return nums[0];
        }
        else if (n == 1)
        {
            return Math.Max(nums[0], nums[1]);
        }

        if (dp[n] != -1) return dp[n];

        return dp[n] = Math.Max(nums[n] + Solve(nums, n - 2), Solve(nums, n - 1));
    }
    public static int Rob(int[] nums)
    {
        int n = nums.Length;

        for (int i = 0; i < 401; i++)
        {
            dp[i] = -1;
        }
        return Solve(nums, n - 1);
    }

    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 1 };
        Console.WriteLine(Rob(nums));
    }
}
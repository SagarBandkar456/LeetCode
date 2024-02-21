using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    public static int MaximizeSum(int[] nums, int k)
    {
        int max = Int32.MinValue;
        for (int i = 0; i < nums.Length; i++) max = Math.Max(max, nums[i]);

        int ans = 0;
        while (k-- > 0)
        {
            ans += max;
            max++;
        }

        return ans;
    }

    public static void Main(string[] args)
    {
        int[] nums = { 2, 3, 4, 5 };
        int k = 3;
        Console.WriteLine(MaximizeSum(nums, k));
    }
}
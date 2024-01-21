using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    public static int MinimumCost(int[] nums)
    {
        int first = nums[0];

        int second = Int32.MaxValue;
        int third = Int32.MaxValue;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < second)
            {
                third = second;
                second = nums[i];
                continue;
            }
            if (nums[i] < third)
            {
                second = second;
                third = nums[i];
            }
        }
        return first + second + third;
    }
    public static void Main(string[] args)
    {
        int[] cost = [1, 2, 3, 12];
        Console.WriteLine(MinimumCost(cost));
    }
}
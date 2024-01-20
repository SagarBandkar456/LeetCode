using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    public static bool CanJump(int[] nums)
    {
        int reach = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > reach) return false;

            reach = Math.Max(reach, nums[i] + i);
        }

        return true;
    }

    public static void Main(string[] args)
    {
        int[] nums = { 10, 15, 20 };
        CanJump(nums);
    }
}
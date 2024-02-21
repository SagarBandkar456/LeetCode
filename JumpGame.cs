using System;

class JumpGame
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
}
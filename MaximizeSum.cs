using System;

public class MaximizeSum
{
    public int MaxSum(int[] nums, int k)
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
}
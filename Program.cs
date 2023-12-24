using System;

class Program
{
    public static int Solve(int[] nums)
    {
        int maxIndex=0;
        int count=0;

        for(int i=0;i<nums.Length;i++)
        {
            maxIndex=Math.Max(maxIndex,nums[i]);

            if(maxIndex==i+1) count++;
        }

        return count;
    }
    public static void Main(string[] args)
    {
        int[] flips = {3,2,4,1,5};
        Solve(flips);
    }
}
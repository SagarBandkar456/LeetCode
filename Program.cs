using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        int[] nums = { 2, 3, 4, 5 };
        int k = 3;

        MaximizeSum maximizeSum = new MaximizeSum();
        Console.WriteLine(maximizeSum.MaxSum(nums, k));
    }
}
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        int[][] nums = {
            new int[] { 4, 3, 2, -1 },
            new int[] { 3,2,1,-1 },
            new int[] { 1,1,-1,-2 },
            new int[] { -1,-1,-2,-3 },
        };
        Console.WriteLine(CountNegative.Count(nums));
    }
}
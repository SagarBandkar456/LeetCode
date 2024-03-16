using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        int count = 1;

        int n = 5;
        for (int i = 1; i <= n; i++)
        {
            int sum = i;
            for (int j = i + 1; j <= n; j++)
            {
                sum += j;
                if (sum > n) break;
                else if (sum == n) count++;
            }
        }


        //Console.WriteLine(CountNegative.Count(nums));
    }
}
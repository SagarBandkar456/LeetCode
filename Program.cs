using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    public static int[] CountBits(int n)
    {
        int[] res = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            res[i] = CountSetBits(i);
        }
        return res;
    }

    static int CountSetBits(int n)
    {
        int count = 0;
        while (n > 0)
        {
            n = n & (n - 1);
            count++;
        }

        return count;
    }
    public static void Main(string[] args)
    {
        int n = 2;
        Console.WriteLine(CountBits(n));
    }
}
using System;
using System.Collections.Generic;

class Program
{
    public static int GetWinner(int[] arr, int k)
    {
        int res = arr[0];
        int cnt = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > res)
            {
                res = arr[i];
                cnt = 0;
            }
            cnt++;

            if (cnt == k) break;
        }

        return res;
    }
    public static void Main(string[] args)
    {
        int[] arr = { 2, 1, 3, 5, 4, 6, 7 };
        int k = 2;
        Console.WriteLine(GetWinner(arr, k));
    }
}
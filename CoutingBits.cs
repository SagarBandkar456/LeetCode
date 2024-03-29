using System;

class CountingBits
{
    public int[] CountBits(int n)
    {
        int[] res = new int[n + 1];
        for (int i = 0; i <= n; i++)
        {
            res[i] = CountSetBits(i);
        }
        return res;
    }

    int CountSetBits(int n)
    {
        int count = 0;
        while (n > 0)
        {
            n = n & (n - 1);
            count++;
        }

        return count;
    }
}
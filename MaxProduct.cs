using System;

class MaxProduct
{
    public int Product(int[] a)
    {
        int size = a.Length;
        int max_so_far = int.MinValue, max_ending_here = 1;

        for (int i = 0; i < size; i++)
        {
            max_ending_here = max_ending_here * a[i];

            if (max_so_far < max_ending_here)
                max_so_far = max_ending_here;

            if (max_ending_here == 0)
                max_ending_here = 1;

        }

        max_ending_here = 1;
        for (int i = a.Length - 1; i >= 0; i--)
        {
            max_ending_here *= a[i];

            max_so_far = Math.Max(max_ending_here, max_so_far);
            if (max_ending_here == 0)
                max_ending_here = 1;
        }

        return max_so_far;
    }
}
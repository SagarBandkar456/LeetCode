using System;

class Segment
{
    public int[] st;
    public Segment(int[] arr, int n)
    {
        int x = (int)(Math.Ceiling(Math.Log(n) / Math.Log(2)));
        int size = 2 * (int)Math.Pow(2, x) - 1;
        st = new int[size];
        ConstructUtil(arr, 0, n - 1, 0);
    }

    public int ConstructUtil(int[] array, int ss, int se, int si)
    {
        if (ss == se)
        {
            st[si] = array[ss];
            return array[ss];
        }

        int mid = GetMid(ss, se);
        st[si] = ConstructUtil(array, ss, mid, 2 * si + 1) + ConstructUtil(array, mid + 1, se, 2 * si + 2);
        return st[si];
    }

    void updateValue(int[] arr, int n, int i, int new_val)
    {
        // Check for erroneous input index
        if (i < 0 || i > n - 1)
        {
            Console.WriteLine("Invalid Input");
            return;
        }

        // Get the difference between
        // new value and old value
        int diff = new_val - arr[i];

        // Update the value in array
        arr[i] = new_val;

        // Update the values of nodes in segment tree
        updateValueUtil(0, n - 1, i, diff, 0);
    }
    void updateValueUtil(int ss, int se, int i,
                                int diff, int si)
    {
        // Base Case: If the input index 
        // lies outside the range of this segment
        if (i < ss || i > se)
            return;

        // If the input index is in range of 
        // this node, then update the value
        // of the node and its children
        st[si] = st[si] + diff;
        if (se != ss)
        {
            int mid = GetMid(ss, se);
            updateValueUtil(ss, mid, i, diff, 2 * si + 1);
            updateValueUtil(mid + 1, se, i, diff, 2 * si + 2);
        }
    }


    public int GetMid(int start, int end)
    {
        return start + (end - start) / 2;
    }

    public int GetSum(int n, int qs, int qe)
    {
        if (qs < 0 || qe > n - 1 || qs > qe)
        {
            return -1;
        }
        return GetSumUtil(0, n - 1, qs, qe, 0);
    }

    public int GetSumUtil(int ss, int se, int qs, int qe, int si)
    {
        if (qs <= ss && qe >= se) return st[si];

        if (ss > qe || se < qs) return 0;

        int mid = GetMid(ss, se);

        return GetSumUtil(ss, mid, qs, qe, 2 * si + 1) + GetSumUtil(mid + 1, se, qs, qe, 2 * si + 2);
    }
}
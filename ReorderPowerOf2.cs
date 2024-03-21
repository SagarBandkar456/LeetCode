using System;

class ReorderPowerOf2
{
    public int[] FreqCount(int n)
    {
        int[] digit = new int[10];

        while (n > 0)
        {
            digit[n % 10]++;
            n = n / 10;
        }

        return digit;
    }

    public bool ReorderCount(int n)
    {
        bool flag = false;
        int[] digit = FreqCount(n);

        for (int i = 0; i < 31; i++)
        {
            int power = (int)Math.Pow(2, i);
            int[] powerOf2 = FreqCount(power);
            if (CompareArray(digit, powerOf2)) return flag = true;
        }

        return flag;
    }

    public bool CompareArray(int[] array1, int[] array2)
    {
        for (int i = 0; i < 10; i++)
        {
            if (array1[i] != array2[i]) return false;
        }
        return true;
    }
}
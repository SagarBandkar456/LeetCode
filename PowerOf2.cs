using System;

class PowerOf2
{
    public bool IsPowerOfTwo(int n)
    {
        if (n == 1) return true;
        if (n == 0 || n % 2 != 0) return false;
        return IsPowerOfTwo(n / 2);
    }
}
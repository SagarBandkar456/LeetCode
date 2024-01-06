using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    public static bool IsPowerOfTwo(int n)
    {
        if (n == 1) return true;
        if (n == 0 || n % 2 != 0) return false;
        return IsPowerOfTwo(n / 2);
    }
    public static void Main(string[] args)
    {
        IsPowerOfTwo(6);
    }
}
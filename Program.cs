using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    public static bool IsPowerOfFour(int n)
    {
        if (n == 1) return true;
        if (n % 4 != 0 && n == 0) return false;
        return IsPowerOfFour(n / 4);
    }
    public static void Main(string[] args)
    {
        int num = 27;
        IsPowerOfFour(num);
    }
}
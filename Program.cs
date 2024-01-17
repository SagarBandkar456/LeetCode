﻿using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

class Program
{
    public static int MinFlips(int a, int b, int c)
    {
        int flip = 0;

        while (a >= 0 || b >= 0 || c >= 0)
        {
            int bitA = a & 1;
            int bitB = b & 1;
            int bitC = c & 1;

            if (bitC == 1) flip++;
            else
            {
                if (bitA == 0 && bitB == 0) flip++;
            }
        }

        return flip;
    }
    public static void Main(string[] args)
    {
        int a = 2, b = 6, c = 5;

        MinFlips(a, b, c);
    }
}
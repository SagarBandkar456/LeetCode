using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    public static int SplitNum(int num)
    {
        int res = 0;
        char[] input = num.ToString().ToCharArray();
        Array.Sort(input);

        string a = "";
        string b = "";

        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0) a += input[i];
            else b += input[i];
        }

        res = Convert.ToInt32(a) + Convert.ToInt32(b);
        return res;
    }
    public static void Main(string[] args)
    {
        int num = 4325;
        SplitNum(num);
    }
}
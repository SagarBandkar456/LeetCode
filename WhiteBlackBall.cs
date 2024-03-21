using System;

class WhiteBlackBall
{
    public int MinimumSteps(string s)
    {
        int res = 0;
        int cnt = 0;
        char[] arr = s.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == '0') res += cnt;
            cnt += arr[i] - '0';
        }

        return res;
    }
}
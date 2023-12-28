using System;
using System.Collections.Generic;

class Program
{
    public static string BestHand(int[] ranks, char[] suits)
    {
        string res = "High Card";
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int flush = 1;

        dict.Add(ranks[0], 1);
        for (int i = 1; i < ranks.Length; i++)
        {
            if (dict.ContainsKey(ranks[i]))
            {
                dict[ranks[i]]++;
                if (dict[ranks[i]] == 2 && res != "Three of a Kind") res = "Pair";
                if (dict[ranks[i]] == 3) res = "Three of a Kind";
            }
            else dict.Add(ranks[i], 1);

            if (suits[i] == suits[i - 1]) flush++;
        }

        if (flush == suits.Length) res = "Flush";

        return res;
    }
    public static void Main(string[] args)
    {
        int[] ranks = { 1, 1, 1, 2, 2 };
        char[] suits = { 'a', 'b', 'c', 'a', 'd' };
        Console.WriteLine(BestHand(ranks, suits));
    }
}
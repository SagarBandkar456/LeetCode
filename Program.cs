using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    public static int EqualPairs(int[][] grid)
    {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        int cnt = 0;
        for (int i = 0; i < grid.Length; i++)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < grid[i].Length; j++)
            {
                sb.Append(grid[i][j]);
            }
            if (dict.ContainsKey(sb.ToString())) dict[sb.ToString()]++;
            else dict.Add(sb.ToString(), 1);
        }

        for (int i = 0; i < grid.Length; i++)
        {
            StringBuilder sb = new StringBuilder();
            for (int j = 0; j < grid[i].Length; j++)
            {
                sb.Append(grid[j][i]);
            }
            if (dict.ContainsKey(sb.ToString()))
            {
                dict[sb.ToString()]++;
            }
            else dict.Add(sb.ToString(), 1);
        }

        foreach (var item in dict)
        {
            if (item.Value > 1) cnt += item.Value - 1;
        }

        return cnt;
    }

    public static void Main(string[] args)
    {
        int[][] grid = [[3, 1, 2, 2], [1, 4, 4, 5], [2, 4, 2, 2], [2, 4, 2, 2]];

        EqualPairs(grid);
    }
}
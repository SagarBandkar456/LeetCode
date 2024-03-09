using System;

class CountNegative
{
    public static int Count(int[][] matrix)
    {
        int count = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (matrix[i][j] < 0) count++;
            }
        }
        return count;
    }
}
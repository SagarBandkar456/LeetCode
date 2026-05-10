using System;

class Dijkstra
{
    public static int v = 9;

    public int MinDistance(int[] dist, bool[] sptSet)
    {
        int minIndex = -1;
        int min = int.MaxValue;

        for (int i = 0; i < v; i++)
        {
            if (!sptSet[i] && dist[i] < min)
            {
                min = dist[i];
                minIndex = i;
            }
        }

        return minIndex;
    }

    public void Solve(int[,] graph, int src)
    {
        int[] dist = new int[v];
        bool[] sptSet = new bool[v];

        for (int i = 0; i < v; i++)
        {
            dist[i] = int.MaxValue;
            sptSet[i] = false;
        }

        dist[src] = 0;

        for (int i = 0; i < v - 1; i++)
        {
            int u = MinDistance(dist, sptSet);

            if (u == -1)
                break;

            sptSet[u] = true;

            for (int j = 0; j < v; j++)
            {
                if (!sptSet[j] &&
                    graph[u, j] != 0 &&
                    dist[u] != int.MaxValue &&
                    dist[u] + graph[u, j] < dist[j])
                {
                    dist[j] = dist[u] + graph[u, j];
                }
            }
        }

        Print(dist);
    }

    void Print(int[] dist)
    {
        Console.WriteLine("Vertex \t Distance");

        for (int i = 0; i < dist.Length; i++)
        {
            Console.WriteLine($"{i} \t {dist[i]}");
        }
    }
}
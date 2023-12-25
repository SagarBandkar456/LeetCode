using System;

class Program
{
    public static int MinDistance(int[] dist, bool[] sptSet, int v)
    {
        int min=Int32.MaxValue, minIndex=-1;

        for(int i=0;i<v;i++)
        {
            if(sptSet[i]==false && dist[i]<min)
            {
                min=dist[i];
                minIndex=i;
            }
        }
        
        return minIndex;
    }

    public static int CountPaths(int n, int[][] roads) {
        int src=0;
        int dest=n-1;

        int[] dist=new int[n];
        bool[] sptSet=new bool[n];

        for(int i=0;i<n;i++)
        {
            sptSet[i]=false;
            dist[i]=Int32.MaxValue;
        }

        dist[src]=0;

        for(int i=0;i<n;i++)
        {
            int u=MinDistance(dist,sptSet,n);

            sptSet[u]=true;
            for (int v = 0; v < n; v++)
 
                if (!sptSet[v] && roads[u][v] != 0
                    && dist[u] != Int32.MaxValue
                    && dist[u] + roads[u][v] < dist[v])
                    dist[v] = dist[u] + roads[u][v];
        }

        return dist[dest];
    }
    public static void Main(string[] args)
    {
        int n = 7;
        int[][] roads = new int[][]
        {
            new int[]{0,6,7},
            new int[]{0,1,2},
            new int[]{1,2,3},
            new int[]{1,3,3},
            new int[]{6,3,3},
            new int[]{3,5,1},
            new int[]{6,5,1},
            new int[]{2,5,1},
            new int[]{0,4,5},
            new int[]{4,6,2},
        };

        CountPaths(n,roads);
    }
}
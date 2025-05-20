using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter the number of vertices: ");
        int vertices = int.Parse(Console.ReadLine());

       
        int[,] graph = new int[vertices, vertices];
        Console.WriteLine("Enter the adjacency matrix (use 0 for no direct path):");
        for (int i = 0; i < vertices; i++)
        {
            string[] weights = Console.ReadLine().Split(' ');
            for (int j = 0; j < vertices; j++)
            {
                graph[i, j] = int.Parse(weights[j]);
            }
        }

    
        Console.Write("Enter the starting node (0 to " + (vertices - 1) + "): ");
        int startNode = int.Parse(Console.ReadLine());

        
        Dijkstra(graph, startNode, vertices);
    }

    static void Dijkstra(int[,] graph, int startNode, int vertices)
    {
        int[] distances = new int[vertices];
        bool[] shortestPathSet = new bool[vertices];
        int[] previous = new int[vertices];

        // Initialize distances and previous nodes
        for (int i = 0; i < vertices; i++)
        {
            distances[i] = int.MaxValue; 
            shortestPathSet[i] = false; 
            previous[i] = -1; 
        }

        distances[startNode] = 0; 

        for (int count = 0; count < vertices - 1; count++)
        {
            
            int u = MinDistance(distances, shortestPathSet, vertices);
            shortestPathSet[u] = true; 

            
            for (int v = 0; v < vertices; v++)
            {
                
                if (!shortestPathSet[v] && graph[u, v] != 0 && distances[u] != int.MaxValue && distances[u] + graph[u, v] < distances[v])
                {
                    distances[v] = distances[u] + graph[u, v];
                    previous[v] = u; 
                }
            }
        }

        
        PrintSolution(distances, previous, startNode, vertices);
    }

    static int MinDistance(int[] distances, bool[] shortestPathSet, int vertices)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for (int v = 0; v < vertices; v++)
        {
            if (!shortestPathSet[v] && distances[v] <= min)
            {
                min = distances[v];
                minIndex = v;
            }
        }
        return minIndex;
    }

    static void PrintSolution(int[] distances, int[] previous, int startNode, int vertices)
    {
        Console.WriteLine("Vertex\tDistance from Source\tPath");
        for (int i = 0; i < vertices; i++)
        {
            Console.Write("Node " + i + "\t" + distances[i] + "\t\t\t");
            PrintPath(previous, i);
            Console.WriteLine();
        }
    }

    static void PrintPath(int[] previous, int j)
    {
        if (j == -1)
            return;

        PrintPath(previous, previous[j]);
        Console.Write(j + " ");
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace PracrticePlaybook
{
    /// <summary>
    /// This is Greedy algorithm
    /// Initially Assume all the values to vertex are infinity (int.Max)
    /// From Vertex 1 find next short and relax
    /// Then select the Shortest and 
    /// </summary>
    public class Djikstra
    {
        int[,] graph;
        int srcVertex;
        bool[] visitedShortestPathVertices;

        int vertexCount = 0;

        public Djikstra()
        {
            graph = new int[,]{
                                { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                { 0, 0, 2, 0, 0, 0, 6, 7, 0 }
                              };
            srcVertex = 0;
            vertexCount = 9;
            visitedShortestPathVertices = new bool[vertexCount];

        }

        public Djikstra(int[,] input, int src)
        {
            graph = input;
            srcVertex = src;
        }

        private int MinDistanceVertex(int currentVertex, int[] currentDistances)
        {
            int min = int.MaxValue;
            int minIndex = 0;
            for (int i = 0; i < vertexCount; i++)
            {
                if (visitedShortestPathVertices[i] == false && currentDistances[i] <= min)
                {
                    min = currentDistances[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }
        private void Print(int[] distance)
        {
            Console.WriteLine("Vertex    Distance from source");

            for (int i = 0; i < vertexCount; ++i)
                Console.WriteLine("{0}\t  {1}", i, distance[i]);
        }
        public void GetSingleSourceShortestPath()
        {
            int[] distances = new int[vertexCount]; // This is carry over from Previous instead having whole graph

            for (int i = 0; i < vertexCount; i++)
            {
                distances[i] = int.MaxValue;
                visitedShortestPathVertices[i] = false;
            }
            distances[this.srcVertex] = 0;
            for (int i = 0; i < vertexCount - 1; i++)
            {
                int shortestDistanceVertex = this.MinDistanceVertex(i, distances);
                visitedShortestPathVertices[shortestDistanceVertex] = true;
                int distanceToNearesteNode = distances[shortestDistanceVertex];
                //Relax distances
                for (int v = 0; v < vertexCount; ++v)
                {
                    if (!visitedShortestPathVertices[v] &&
                        Convert.ToBoolean(graph[shortestDistanceVertex, v]) &&  // If there is DirectDistance of SelectedNode to Current Node
                        distanceToNearesteNode != int.MaxValue && // If Relaxed
                        distanceToNearesteNode + graph[shortestDistanceVertex, v] < distances[v]) // Check if needs relaxation or not i.e if current nodes distance is shorter via selectednode or not

                        distances[v] = distanceToNearesteNode + graph[shortestDistanceVertex, v];
                }
                Print(distances);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PracrticePlaybook
{

    /// <summary>
    /// Get Minnode looking from one node
    /// Goto MinNode , explore all and add CurrentNode to ResultSet
    /// </summary>
    //public class Graph {
    //    public int VertextCount;
    //    public int EdgeCount;
    //    public List<Edge> Edges;

    //}

    //public class Edge
    //{
    //    public int Source;
    //    public int Destination;
    //    public int Weight;
    //}

    public class PrimsMinSpanTree
    {
        //Graph graph;
        int[,] graph;
        Stack<int> currentNodes;
        int[] distances;
        int[] parent;
        bool[] includedSet;
        int vertexCount;
        int edgeCount;

        public PrimsMinSpanTree()
        {
            graph = new int[,]{
                                { 0, 2, 0, 6, 0 },
                                { 2, 0, 3, 8, 5 },
                                { 0, 3, 0, 0, 7 },
                                { 6, 8, 0, 0, 9 },
                                { 0, 5, 7, 9, 0 }
                            };
            vertexCount = 5;
        }

        public int GetMinNode()
        {
            int min = int.MaxValue, minIndex = int.MaxValue;
            for (int v = 0; v < vertexCount; v++)
                if (!includedSet[v] && distances[v] < min)
                {
                    min = distances[v];
                    minIndex = v;
                }

            return minIndex;
        }

        public void GetMininimumSpanningTree()
        {
            //Initialize the distances
            distances = new int[vertexCount];
            parent = new int[vertexCount];
            includedSet = new bool[vertexCount];

            for (int i = 0; i < vertexCount - 1; i++)
            {
                distances[i] = int.MaxValue;
                parent[i] = int.MaxValue;
                includedSet[i] = false;
            }

            currentNodes.Push(0);

            for (int i = 0; i < vertexCount; i++)
            {
                int minNodeIndex = GetMinNode();
                includedSet[minNodeIndex] = true;
                for (int v = 0; v < vertexCount; v++)
                {
                    if (graph[minNodeIndex, v] != 0 && !includedSet[v] 
                   && graph[minNodeIndex, v] < distances[v])
                    {
                        parent[v] = minNodeIndex;
                        distances[v] = graph[minNodeIndex, v];
                    }
                }
            }
        }
    }
}

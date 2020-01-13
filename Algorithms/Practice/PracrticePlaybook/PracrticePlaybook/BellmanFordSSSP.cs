using System;
using System.Collections.Generic;
using System.Text;

namespace PracrticePlaybook
{
    public class BellmanFordSSSP
    {
        List<int> distances = new List<int>();
        List<int?> parents = new List<int?>();
        int? origin;

        Graph graph;

        public class Edge
        {
            public int Destination;
            public int Source;
            public int Weight;
        }
        public class Graph
        {
            public List<Edge> Edges = new List<Edge>();
            public int EdgeCount;
            public int VertexCount;
        }
        public BellmanFordSSSP()
        {
            graph = new Graph();
            graph.VertexCount = 4;
            graph.EdgeCount = 3;

            graph.Edges.Add(new Edge { Source = 0, Destination = 1, Weight = 1 });
            graph.Edges.Add(new Edge { Source = 1, Destination = 2, Weight = 2 });
            graph.Edges.Add(new Edge { Source = 2, Destination = 3, Weight = 3 });

            origin = 0;

        }


        private void Print()
        {
            Console.WriteLine("Vertex   Distance    Parent from source");

            for (int i = 0; i < graph.VertexCount; ++i)
                Console.WriteLine("{0}\t {1}\t {2}", i, distances[i], parents[i]);
        }

        public void GetShortestPaths()
        {

            // Step1: Initialze Distances fro source to all vertices a infinity
            for (int i = 0; i < graph.VertexCount; i++)
            {
                distances.Add(int.MaxValue);
                parents.Add(null);
            }
            distances[origin.Value] = 0;

            for (int i = 0; i < graph.VertexCount - 1; i++)
            {
                for (int j = 0; j < graph.EdgeCount; j++)
                {
                    Edge currentEdge = graph.Edges[j];
                    int distanceFromOriginToSource = distances[currentEdge.Source];

                    //If Source is Relaxed , relax Destination
                    if (distanceFromOriginToSource != int.MaxValue && distanceFromOriginToSource + currentEdge.Weight < distances[currentEdge.Destination])
                    {
                        distances[currentEdge.Destination] = distanceFromOriginToSource + currentEdge.Weight;
                        parents[currentEdge.Destination] = currentEdge.Source;
                    }
                }


            }
            //Check For Negative Cycles, Do one more Iteration
            for (int j = 0; j < graph.EdgeCount; j++)
            {

                Edge currentEdge = graph.Edges[j];
                int distanceFromOriginToSource = distances[currentEdge.Source];

                //If Source is Relaxed , relax Destination
                if (distanceFromOriginToSource != int.MaxValue && distanceFromOriginToSource + currentEdge.Weight < distances[currentEdge.Destination])
                {
                    throw new Exception("Graph has Negative edges");
                }
            }
            Print();
        }
    }
}

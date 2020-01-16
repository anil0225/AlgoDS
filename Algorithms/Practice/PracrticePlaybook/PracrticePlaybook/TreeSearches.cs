using System;
using System.Collections.Generic;
using System.Text;

namespace PracrticePlaybook
{

    public class Edge<T>
    {
        public T Source;
        public T Destination;
        public int Weight;
    }
    public class Vertex<T>
    {
        public T ID;
        public List<Vertex<T>> Children = new List<Vertex<T>>();
    }
    public class Graph<T>
    {
        public List<Edge<T>> Edges = new List<Edge<T>>();
        public List<Vertex<T>> Verticies = new List<Vertex<T>>();
    }
    /// <summary>
    ///         A
    ///       / | \
    ///      B  C  D
    ///     / \ |     \
    ///    E    F      G
    /// </summary>
    public class TreeSearches
    {
        Graph<string> graph;
        List<string> visited = new List<string>();
        public TreeSearches()
        {
            graph = new Graph<string>();
            Vertex<string> A = new Vertex<string> { ID = "A" };
            Vertex<string> B = new Vertex<string> { ID = "B" };
            Vertex<string> C = new Vertex<string> { ID = "C" };
            Vertex<string> D = new Vertex<string> { ID = "D" };
            Vertex<string> E = new Vertex<string> { ID = "E" };
            Vertex<string> F = new Vertex<string> { ID = "F" };
            Vertex<string> G = new Vertex<string> { ID = "G" };


            A.Children.Add(B);
            A.Children.Add(C);
            A.Children.Add(D);

            B.Children.Add(E);
            B.Children.Add(F);

            C.Children.Add(F);

            D.Children.Add(G);

            graph.Verticies = new List<Vertex<string>> { A, B, C, D, E, F, G };

            Console.Write("Performing DFS over the Tree \n");
            foreach (var vertex in graph.Verticies)
            {
                DFS(vertex);
            }

            Console.Write(Environment.NewLine);
            Console.Write("Performing BFS over the Tree \n");
            BFS(A);
        }

        public void DFS(Vertex<string> rootVertex)
        {

            if (!visited.Contains(rootVertex.ID))
            {

                visited.Add(rootVertex.ID);
                Console.Write("{0}\t", rootVertex.ID);
                foreach (Vertex<string> vertex in rootVertex.Children)
                {
                    DFS(vertex);
                }

            }

        }

        public void BFS(Vertex<string> node)
        {

            Queue<Vertex<string>> queue = new Queue<Vertex<string>>();
            List<string> bfsVisited = new List<string>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                Vertex<string> current = queue.Dequeue();
                if (!bfsVisited.Contains(current.ID))
                {
                    bfsVisited.Add(current.ID);

                    Console.Write("{0}\t", current.ID);

                    foreach (Vertex<string> vertex in current.Children)
                    {
                        queue.Enqueue(vertex);
                    }
                }

            }
        }
    }
}

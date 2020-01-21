using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PracrticePlaybook
{
    //Itertea and Visit
    //Once All childrent explolred then add to stack
    public class TopologicalSort
    {
        Dictionary<string, List<string>> nodesList;
        HashSet<string> visited = new HashSet<string>();
        //DFS use Stack
        Stack<string> result = new Stack<string>();
        public TopologicalSort(Dictionary<string, List<string>> input)
        {
            this.nodesList = input;
        }

        public TopologicalSort()
        {
            this.nodesList = new Dictionary<string, List<string>>();
            this.nodesList.Add("A", new List<string> { "C" });
            this.nodesList.Add("B", new List<string> { "C", "D" });
            this.nodesList.Add("C", new List<string> { "E" });
            this.nodesList.Add("D", new List<string> { "F" });
            this.nodesList.Add("E", new List<string> { "H", "F" });
            this.nodesList.Add("F", new List<string> { "G" });
            this.nodesList.Add("G", new List<string>());
            this.nodesList.Add("H", new List<string>());
        }
        public void Visit(string node)
        {
            visited.Add(node);
            foreach (string child in nodesList[node])
            {
                if (!visited.Contains(child))
                {
                    Visit(child);
                }
            }
            result.Push(node);

        }

        void PrintResult()
        {
            while (result.Count > 0)
            {
                Console.Write(result.Pop());
            }
        }
        public Stack<string> GetSequence()
        {
            foreach (KeyValuePair<string, List<string>> node in nodesList)
            {
                if (!visited.Contains(node.Key))
                    Visit(node.Key);
            }

            PrintResult();
            return result;
        }
    }

}

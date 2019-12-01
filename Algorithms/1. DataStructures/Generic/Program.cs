using System;
using System.Collections;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        // Arrays
        // Linked List
        // Hash Table
        // Stacks
        // Queue
        // Trees
        // https://github.com/gt4dev/yet-another-tree-structure/blob/master/csharp/CSharpTree/TreeNode.cs
        // Graphs
        // http://www.vcskicks.com/representing-graphs.php

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Array
            int[] arr = new int[5];
            //Default Intialize
            arr = new int { 1, 2, 3, 4, 5 };

            // 2 Dimensional Array
            int[,] dimArray2 = new int[2, 2];
            // Init
            dimArray2 = new int[2, 2] { { 0, 0 }, { 0, 1 }, { 1, 0 }, { 1, 1 } };
            dimArray[0, 0] = 1;
            dimArray[0, 1] = 2;


            // Linked List
            LinkedList<int> ll = new LinkedList<int>();
            // Init
            ll = new LinkedList<int> { 1, 2, 3, 4, 5 };
            ll.AddFirst(1);
            ll.AddLast(2);
            ll.AddLast(3);

            // Hash Table
            Hashtable ht = new Hashtable();
            ht.Add(1, 100);
            Console.WriteLine(ht[1]);

            // Hash Set
            HashSet hs = new HashSet();
            hs.Add(200);
            hs.Add(300);
            hs.Add(600);
            hs.Contains(200);
            Console.WriteLine(hs[200]);


            // Stack
            Stack st = new Stack();
            st.Push("One");
            st.Push("Two");
            Console.WriteLine(st.Peek());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());

            // Queue
            Queue qu = new Queue();
            qu.Enqueue("One");
            qu.Enqueue("Two");
            Console.WriteLine(qu.Dequeue());
            Console.WriteLine(qu.Dequeue());

        }
    }
}

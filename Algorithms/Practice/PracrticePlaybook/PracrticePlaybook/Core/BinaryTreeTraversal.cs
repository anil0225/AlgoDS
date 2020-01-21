using System;
using System.Collections.Generic;
using System.Text;

namespace PracrticePlaybook
{
    public class TreeNode<T>
    {
        public TreeNode<T> Left;
        public TreeNode<T> Right;
        public T Value;
    }

    /// <summary>
    ///     1
    ///    / \
    ///   2   3 
    ///  /    /
    /// 4    5
    /// </summary>
    public class BinaryTreeTraversal
    {
        TreeNode<int> tree;
        public BinaryTreeTraversal()
        {
            tree = new TreeNode<int> { Value = 1 };
            tree.Left = new TreeNode<int> { Value = 2 };
            tree.Right = new TreeNode<int> { Value = 3 };
            tree.Left.Left = new TreeNode<int> { Value = 4 };
            tree.Right.Left = new TreeNode<int> { Value = 5 };

            Console.WriteLine("\n Inorder Traversal");
            InorderTraversal(tree);
            Console.WriteLine("\n Preorder Traversal");
            PreOrderTraversal(tree);
            Console.WriteLine("\n Postorder Traversal");
            PostOrderTraversal(tree);

            Console.WriteLine("\n DFS Traversal");
            DFSInorderUsingStack();

            Console.WriteLine("\n BFS Traversal");
            BFSInorderUsingQueue();

        }

        /// <summary>
        /// Left Root Right
        /// </summary>
        /// <param name="treeNode"></param>
        public void InorderTraversal(TreeNode<int> treeNode)
        {
            if (treeNode == null)
                return;

            InorderTraversal(treeNode.Left);
            Console.Write(treeNode.Value);
            Console.Write("\t");
            InorderTraversal(treeNode.Right);
        }

        /// <summary>
        /// Root Left Right 
        /// </summary>
        public void PreOrderTraversal(TreeNode<int> treeNode)
        {
            if (treeNode == null)
                return;

            Console.Write(treeNode.Value);
            Console.Write("\t");
            PreOrderTraversal(treeNode.Left);
            PreOrderTraversal(treeNode.Right);
        }

        /// <summary>
        /// Right Root Left
        /// </summary>
        public void PostOrderTraversal(TreeNode<int> treeNode)
        {
            if (treeNode == null)
                return;

            PostOrderTraversal(treeNode.Right);
            Console.Write(treeNode.Value);
            Console.Write("\t");
            PostOrderTraversal(treeNode.Left);
        }

        /// <summary>
        /// DFS makes use of Stack to compensate Recursion
        /// Also needs to keep track of the visited Nodes
        /// </summary>
        /// <param name="treeNode"></param>
        public void DFSInorderUsingStack()
        {
            Stack<TreeNode<int>> stack = new Stack<TreeNode<int>>();
            TreeNode<int> currentNode = tree;

            while (stack.Count > 0 || currentNode != null)
            {

                // Traverse Till You Reach on the Leaf on the Left (Visit Left)
                while (currentNode != null)
                {
                    stack.Push(currentNode);
                    currentNode = currentNode.Left;
                }

                currentNode = stack.Pop();
                // Visit Current
                Console.Write(currentNode.Value);
                Console.Write("\t");
                // Start Visiting Right
                currentNode = currentNode.Right;
            }
        }

        public void BFSInorderUsingQueue()
        {
            Queue<TreeNode<int>> queue = new Queue<TreeNode<int>>();

            queue.Enqueue(tree);

            while (queue.Count > 0)
            {
                TreeNode<int> currentNode = queue.Dequeue();
                Console.Write(currentNode.Value);
                Console.Write("\t");
                if (currentNode.Left != null)
                    queue.Enqueue(currentNode.Left);
                if (currentNode.Right != null)
                    queue.Enqueue(currentNode.Right);                
            }

        }
    }
}

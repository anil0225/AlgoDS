using System;
using System.Collections;
using System.Collections.Generic;

namespace TreeDefinitions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Building Binary Tree");
        }
    }

    public class BinaryTree<T> where T : IComparable
    {

        private BinaryTreeNode<T> head;
        private int size;
        private Comparison<IComparable> comparer = CompareNodeValues;
        public BinaryTree(T rootValue)
        {
            head = new BinaryTreeNode<T>(rootValue);
            size++;
        }
        public virtual BinaryTreeNode<T> Root
        {
            get { return head; }
        }

        public int count
        {
            get
            {
                return this.size;
            }
        }

        public void Add(T nodeValue)
        {
            if (head.Value == null)
            {
                this.head = new BinaryTreeNode<T>(nodeValue);
            }
            else
            {
                this.InsertRecursive(this.Root, nodeValue);
            }
        }


        public void Remove()
        {

        }

        public bool Contains()
        {
            return false;
        }


        public BinaryNode 


        private static int CompareNodeValues(IComparable x, IComparable y)
        {
            return x.CompareTo(y);
        }

        private void InsertRecursive(BinaryTreeNode<T> currentNode, T nodeValue)
        {
            // If value is Greater Traverse Right
            if (comparer((IComparable)currentNode.Value, (IComparable)nodeValue) <= 0)
            {
                if (currentNode.Left == null)
                {
                    currentNode.Left = new BinaryTreeNode<T>(nodeValue);
                }
                else
                {
                    this.InsertRecursive(currentNode.Left, nodeValue);
                }
            }
            else
            {
                if (currentNode.Right == null)
                {
                    currentNode.Right = new BinaryTreeNode<T>(nodeValue);
                }
                else
                {
                    this.InsertRecursive(currentNode.Right, nodeValue);
                }
            }
        }


        private void InsertIterative()
        {

        }
        public void Remove(T value){

        }

        private bool TraverseInorder(T value)
        {
            return false;
        }

        private bool TraversePreOrder(T value)
        {
            return false;
        }

        private bool TraversalPostOrder(T value)
        {
            return false;
        }


    }

    public class BinaryTreeNode<T> where T : IComparable
    {
        T nodeValue;
        public BinaryTreeNode(T value)
        {
            nodeValue = value;
        }
        public BinaryTreeNode<T> Right { get; set; }
        public BinaryTreeNode<T> Left { get; set; }
        public BinaryTreeNode<T> Parent { get; set; }
        public T Value { get { return nodeValue; } }
        public bool IsLeaf
        {
            get
            {
                return this.Right == null && this.Left == null;
            }
        }


    }
}

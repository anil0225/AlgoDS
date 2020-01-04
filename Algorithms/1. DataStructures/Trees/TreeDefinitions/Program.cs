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

    public class BinaryTree<T>: ICollection<T> where T:IComparable
    {

        private BinaryTreeNode<T> head;
        public BinaryTree(T rootValue){
            head = new BinaryTreeNode<T>(rootValue);
        }
        public virtual BinaryTreeNode<T> Root
        {
            get { return head; }
        }

        public int GetSize(){

        }

        public void Add(T nodeValue){
            
        }


        public void Remove(){
            
        }

        public bool Contains(){

        }
        
        private void InsertRecursive(){

        }

        private void InsertIterative(){

        }

        private bool TraverseInorder(T){

        }

        private bool TraversePreOrder(T) {}

        private bool TraversalPostOrder(T) {
            
        }


    }

    public class BinaryTreeNode<T> where T:IComparable
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PracrticePlaybook
{
    public class Node<V> : IComparable
    {
        public int Weight { get; set; }
        public V Value;

        public int CompareTo(object obj)
        {
            return this.Weight - ((Node<V>)obj).Weight;
        }
    }
    public class MinHeap<T> where T : Node<T>
    {
        List<Node<T>> nodes = new List<Node<T>>();

        public void Queue(T node)
        {
            nodes.Add(node);

            this.BubbleUp(node, nodes.Count - 1);
        }

        public void DeQeue(T Node)
        {
            Node<T> returnNode = nodes[0];
            Swap(0, nodes.Count - 1);
            this.BubbleDown(0);
            nodes.RemoveAt(nodes.Count - 1);
        }

        private void BubbleUp(Node<T> currentNode, int index)
        {
            while (this.IsParentBigger(index))
            {
                this.Swap(index, index / 2);
                index = index / 2;
            }

        }

        private void Swap(int sourceIndex, int targetIndex)
        {
            T data = nodes[sourceIndex].Value;
            int weight = nodes[sourceIndex].Weight;
            nodes[sourceIndex].Value = nodes[targetIndex].Value;
            nodes[sourceIndex].Weight = nodes[targetIndex].Weight;

            nodes[targetIndex].Value = data;
            nodes[targetIndex].Weight = weight;
        }

        private bool IsParentBigger(int currentIndex)
        {
            if (currentIndex == 1)
            {
                return false;
            }
            int parentIndex = currentIndex / 2;
            return this.nodes[parentIndex].CompareTo(this.nodes[currentIndex]) > 0;

        }
        private void BubbleDown(int currentIndex)
        {
            bool leftChildSmaller = this.IsLeftChildSmaller(currentIndex);
            bool rightChildSmaller = this.IsRightChildSmaller(currentIndex);
            if (leftChildSmaller || rightChildSmaller)
            {
                if (leftChildSmaller && rightChildSmaller) {
                    if (this.nodes[currentIndex * 2 + 1].CompareTo(this.nodes[currentIndex * 2 + 2]) > 0)
                    {
                        Swap(currentIndex * 2 + 1, currentIndex);
                    }
                    else {
                        Swap(currentIndex * 2 + 2, currentIndex);
                    }
                }
                if (leftChildSmaller)
                {
                    Swap(currentIndex, currentIndex * 2 + 2);
                    BubbleDown(currentIndex * 2 + 2);
                }
                else if (rightChildSmaller) {
                    Swap(currentIndex, currentIndex * 2 + 1);
                    BubbleDown(currentIndex * 2 + 1);
                }
            }

        }

        private bool IsRightChildSmaller(int currentIndex)
        {

            int rightChildIndex = currentIndex * 2 + 1;
            if (rightChildIndex > nodes.Count - 1)
            {
                return false;
            }
            return this.nodes[rightChildIndex].CompareTo(nodes[currentIndex]) < 0;
        }

        private bool IsLeftChildSmaller(int currentIndex)
        {
            int leftChildIndex = currentIndex * 2 + 2;
            if (leftChildIndex > nodes.Count - 1)
            {
                return false;
            }
            return this.nodes[leftChildIndex].CompareTo(nodes[currentIndex]) < 0;
        }

        private void SwapNodes()
        {
        }
    }
}

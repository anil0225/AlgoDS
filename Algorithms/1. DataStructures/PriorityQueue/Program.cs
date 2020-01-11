using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class PriorityQueueu<T> where T : IComparable
    {

        List<T> storedValues;

        public virtual int Count
        {
            get { return storedValues.Count - 1; }
        }

        public PriorityQueueu()
        {
            storedValues = new List<T>();
        }
        public void Enqueue(T value)
        {
            // Add to list and 
            // Call Bubble Down to Push value to desired place
            // We are adding number assuming it to be larger (so always are at the right), so if its not move it to its position
            this.storedValues.Add(value);
            this.BubbleUp();
        }
        public T Dequeue()
        {

            // Remove Last Value 
            // Place max value at the top 
            // Bubble Down
            if (this.Count == 0)
                return default(T);
            else
            {
                T returnValue = this.storedValues[1];
                if (this.Count > 2)
                {
                    T lastValue = this.storedValues[this.Count];
                    this.storedValues.RemoveAt(this.storedValues[this.Count]);
                    this.storedValues[1] = lastValue;
                    this.BubbleDown(1);
                }
                else
                {
                    storedValues.RemoveAt(1);
                }
                return returnValue;
            }


        }

        public T Peek()
        {

        }

        private void BubbleDown(int currentCell)
        {
            while (this.IsLeftChildSmaller(currentCell) || this.IsRightChildSmaller(currentCell))
            {

                if (this.GetSwapChild(currentCell) == 1)
                {
                    //Swap Right
                    T parentValue = storedValues[currentCell];
                    T rightChildValue = storedValues[2 * currentCell + 1];

                    storedValues[currentCell] = rightChildValue;
                    storedValues[2 * currentCell + 1] = parentValue;

                    currentCell = 2 * currentCell + 1; //move down to right child
                }
                else (this.GetSwapChild(currentCell) == -1)
                {
                    //Swap Left
                    T parentValue = storedValues[currentCell];
                    T leftChildValue = storedValues[2 * currentCell];

                    storedValues[currentCell] = leftChildValue;
                    storedValues[2 * currentCell] = parentValue;

                    currentCell = 2 * currentCell; //move down to left child
                }
            }
        }

        private void BubbleUp(int currentCell)
        {
            // While parent is bigger Swap
            while (IsParentBigger(currentCell))
            {
                T targetParent = storedValues[currentCell];
                T targetChild = storedValues[currentCell / 2];

                storedValues[currentCell] = targetChild;
                stored[currentCell / 2] = targetParent;
                currentCell = currentCell / 2;
            }
        }

        private bool IsParentBigger(int currentCell)
        {
            if (currentCell == 1)
                return false;
            else
                return storedValues[currentCell / 2].CompareTo(storedValues[currentCell]) > 0;
        }

        private bool IsLeftChildSmaller(int parentCell)
        {
            int leftChildCell = 2 * parentCell;
            if (leftChildCell >= storedValues.Count)
                return false;
            else
                return storedValues[leftChildCell].CompareTo(parentCell) < 0;
        }

        private boool IsRightChildSmaller(int parentCell)
        {
            int rightChildCell = 2 * parentCell + 1;
            if (rightChildCell >= storedValues.Count)
                return false;
            else
                return storedValues[rightChildCell].CompareTo(parentCell) < 0;
        }

        // -1 left
        // 1 Right
        // 0 No more movement
        private int GetSwapChild(int parentCell)
        {
            bool leftChildSmaller = this.IsLeftChildSmaller(parentCell);
            bool rightChildSmaller = this.IsRightChildSmaller(parentCell);

            if (leftChildSmaller || rightChildSmaller)
            {
                if (leftChildSmaller && rightChildSmaller)
                {
                    if (storedValues[2 * parentCell] < storedValues[2 * parentCell + 1])
                        return -1;
                    else
                        return 1;
                }
                else if (leftChildSmaller)
                    return -1;
                else
                    return 1;
            }
            else
                return 0;
        }

    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    /// <summary>
    /// Merge works of Divide and Compute
    /// T(n) = 2T(n/2) + Theta(n)
    /// nLog(n)
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int length = input.Length;
            Sort(input, 0, length - 1);
            Console.WriteLine("Merge Sort");
            for (int i = 0; i < length ; i++)
            {
                Console.WriteLine(input[i]);
            }
            Console.ReadLine();
        }

        private static void Sort(int[] input, int start, int end)
        {
            int mid;
            if (start < end)
            {
                mid = start + (end - start) / 2;
                //Get first Half
                Sort(input, start, mid);
                //Get Secotend Half
                Sort(input, mid + 1, end);
                DoMerge(input, start, mid, end);
            }

        }

        /// <summary>
        /// Create Left Array
        /// Create Right Array
        /// Maintain current pointer in the Main Array
        /// Compare Left pointer and Right Pointer 
        /// Copy the list value to current pointer  and increment current and left/right
        /// </summary>
        /// <param name="input"></param>
        /// <param name="start"></param>
        /// <param name="mid"></param>
        /// <param name="end"></param>
        private static void DoMerge(int[] input, int start, int mid, int end)
        {
            int leftSize = mid - start + 1;
            int rightSize = end - mid;


            //Create Left and Right Array
            int[] leftArr = new int[leftSize];
            int[] rightArr = new int[rightSize];

            for (int i = 0; i < leftSize; i++)
            {
                leftArr[i] = input[start + i];
            }

            for (int j = 0; j < rightSize; j++)
            {
                rightArr[j] = input[mid + 1 + j];
            }


            int rightPointer = 0, leftPointer = 0, currentPointer = start;

            //Merge till we get onto Border of either left/right array
            while (rightPointer < rightSize && leftPointer < leftSize)
            {
                if (rightArr[rightPointer] > leftArr[leftPointer])
                {
                    input[currentPointer] = leftArr[leftPointer];
                    leftPointer++;
                }
                else
                {
                    input[currentPointer] = rightArr[rightPointer];
                    rightPointer++;
                }
                currentPointer++;
            }


            //Fill Missing Right Array
            while (rightPointer < rightSize)
            {
                input[currentPointer] = rightArr[rightPointer];
                rightPointer++;
                currentPointer++;
            }

            //Fill From Missing Left Array
            while (leftPointer < leftSize)
            {
                input[currentPointer] = leftArr[leftPointer];
                leftPointer++;
                currentPointer++;
            }
        }
    }
}

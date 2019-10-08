using System;

namespace MergeSort
{
    class Program
    {
        
        public class MergeSort
        {
            public void Sort(int[] input, int start, int end)
            {

                if (end > start)
                {
                    int midPointer = (start + end) / 2;
                    Sort(input, start, midPointer);
                    Sort(input, midPointer + 1, end);
                    Merge(input, start, midPointer, end);
                }
            }

            public void Merge(int[] input, int start, int mid, int end)
            {
                int leftArraySize = mid - start +1;
                int rightArraySize = end - mid ;
                int[] leftArray = new int[leftArraySize];
                int[] rightArray = new int[rightArraySize];
                int currentPointer = start;
                int leftPointer = 0;
                int rightPointer = 0;
                int arrayPointer = start;


                for (int i = 0; i < leftArraySize; i++)
                {
                    leftArray[i] = input[start + i];
                }
                for (int i = 0; i < rightArraySize; i++)
                {
                    rightArray[i] = input[(mid + 1) + i];
                }

                while (leftPointer < leftArraySize && rightPointer < rightArraySize)
                {
                    if (leftArray[leftPointer] < rightArray[rightPointer])
                    {
                        input[arrayPointer] = leftArray[leftPointer];
                        leftPointer++;
                    }
                    else
                    {
                        input[arrayPointer] = rightArray[rightPointer];
                        rightPointer++;
                    }
                    arrayPointer++;
                }

                while (leftPointer < leftArraySize)
                {
                    input[arrayPointer] = leftArray[leftPointer];
                    leftPointer++;
                    arrayPointer++;
                }

                while (rightPointer < rightArraySize)
                {
                    input[arrayPointer] = rightArray[rightPointer];
                    rightPointer++;
                    arrayPointer++;
                }

            }
            public void printArray(int[] input)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    Console.Write($"{input[i]},");
                }

                Console.WriteLine();

            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lets start to do the Merge Sort");
            int[] input = { 2, 4, 1, 9, 3, 66, 33, 11 };
            MergeSort sorter = new MergeSort();
            sorter.Sort(input, 0, input.Length - 1);
            sorter.printArray(input);

        }
    }
}

using System;

namespace MergeSort
{
    class Program
    {
        public class MergeSort
        {
            public int[] Sort(int[] input, int start, int end)
            {
                int midPointer = end - start / 2;
                Sort(input, start, midPointer);
                Sort(input, midPointer + 1, end);
                Merge(input, start, end);
            }

            public int[] Merge(int[] input, int start1, int end1, int start2, int end2)
            {
                int rightPointer = start1;
                int leftPointer = start2;

                int leftArray = new int[end1 - start1];
                int rightArray = new int[end2 - start2];

                for (int i = start1; i < end1; i++)
                {
                    leftArray[i] = input[i];
                }

                for (int i = start2; i < end2; i++)
                {
                    rightArray[i] = input[i];
                }

                int pointer = start1;
                while (start1 > end1 && start2 > end2)
                {
                    if (input[leftPointer] < input[rightPointer])
                    {
                        leftPointer++;
                        pointer++;
                        input[pointer] = input[leftPointer];

                    }
                    else
                    {
                        input[pointer] = input[rightPointer];
                        rightPointer++;
                        pointer++;
                    }
                }
                while(pointer < end1){
                    input[pointer] =  input[leftPointer];
                    leftPointer++;
                }
                
                while(pointer < end2){
                    input[pointer] =  input[rightPointer];
                    rightPointer++;
                }

                return input;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lets start to do the Merge Sort");
            int[] input = { 2, 4, 1, 9, 3, 66, 33, 11 };
            MergeSort sorter = new MergeSort();
            var result = sorter.sort(input, 0, input.Length - 1);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{input[i]},");
            }

        }
    }
}

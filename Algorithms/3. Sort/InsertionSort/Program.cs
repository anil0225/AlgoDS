using System;

namespace InsertionSort
{
    // Approach
    // We need to pick an item starting from 2nd position and compare it to the left of the position and keep the item in its ordered place
    // 1. We need to iterate the given Array (Outer loop)
    // 2. Start iterating from 2nd postion
    // 3. We need a pointer to point the elements to left 
    // 4. Since we need to insert the element at position and move all to right, lets pull the item to be compared out of array
    // 5. Now start moving the elements of the array in the left to right until value to be place  < element at the pointer
    // 6. Decrement the pointer till we satisfy 5 and iterate
    // 7. Once satisfied , place the element at the pointed location
    class Program
    {
        public class InsertionSort
        {
            public int[] sort(int[] input)
            {
                int pointer = 0;

                for (int i = 1; i < input.Length; i++)
                {
                    int valuetoPlace = input[i];
                    pointer = i - 1;
                    while (pointer >= 0 && input[pointer] > valuetoPlace)
                    {
                        input[pointer + 1] = input[pointer];
                        pointer--;
                    }
                    input[pointer + 1] = valuetoPlace;
                }
                return input;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Time for Insertion Sort");
            int[] input = { 2, 4, 1, 9, 3, 66, 33, 11 };
            InsertionSort sorter = new InsertionSort();
            var result = sorter.sort(input);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{input[i]},");
            }

        }
    }
}

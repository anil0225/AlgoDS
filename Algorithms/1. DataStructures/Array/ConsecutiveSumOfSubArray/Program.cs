using System;

namespace SumOfSubArray
{
    // Find Continuous array whose sum is as given
    // Add all the the ints start from first pointer till the sum >= required sum
    // If the sum is equal print Array
    // If sum >  remove the first interger and proceed  next
    class Program
    {
        static void PrintArray(int[] input, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                Console.Write($"{input[i]},");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] input = { 2, 0, 1, 3, 5, 6 };
            int requiredSum = 6;

            int currentArraySum = 0;

            int arrayPointer = 0;
            for (int i = 0; i < input.Length; i++)
            {
                while (currentArraySum < requiredSum && arrayPointer < input.Length)
                {
                    currentArraySum += input[arrayPointer];
                    arrayPointer++;
                }
                if (currentArraySum == requiredSum)
                {
                    PrintArray(input, i, arrayPointer);
                }

                currentArraySum -= input[i];

            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace AllSubsets
{
    // Data structures needed
    // Result Container to hold all the arrays so List<List<int>> , Array of current Set List<int>, Actual Input int[1,2,3]
    // Algorithm
    // Take the input
    // 1. Start to iterate from position 0
    // 2. At Position 0
    // 3. Create Temp with [1] and push it to Container
    // 4. Iterate Sub Function (It)
    // 5. Remove the Added Element and move cursor to Next element
    class BackTracker 
    {
        public void Subset(int[] nums, List<List<int>> resultContainer, List<int> tempList, int start)
        {
            var temp = new List<int>(tempList);
            // PrintList(temp);
            resultContainer.Add(temp);
            PrintResultSet(resultContainer);
            for (int i = start; i < nums.Length; i++)
            {
                temp.Add(nums[i]);
                Subset(nums, resultContainer, temp, i + 1);
                temp.RemoveAt(temp.Count - 1);
            }
        }

        public void PrintList(List<int> tempList)
        {
            Console.WriteLine("Printing Temp List [");
            
            foreach (var item in tempList)
            {
                Console.Write($"{item},");
            }
            Console.WriteLine("]");
        }

        public void PrintResultSet(List<List<int>> resultContainer)
        {
            Console.WriteLine("Printing Result Container");
            foreach (var item in resultContainer)
            {
                Console.Write("[");
                foreach (var resultInt in item)
                {
                    Console.Write($"{resultInt},");
                }
                Console.WriteLine("]");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time for Doing Full Backtrack");
            int[] input = { 1, 2, 3 };
            Array.Sort(input);
            Console.WriteLine("Hello World!");
            List<List<int>> resultContainer = new List<List<int>>();
            BackTracker backTracker = new BackTracker();
            backTracker.Subset(input, resultContainer, new List<int>(), 0);
            backTracker.PrintResultSet(resultContainer);
        }


    }
}

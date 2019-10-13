﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace AllSubsets
{
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
        }


    }
}

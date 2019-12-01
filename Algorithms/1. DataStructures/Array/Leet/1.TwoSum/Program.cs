using System;
using System.Collections;
using System.Collections.Generic;

namespace _1.TwoSum
{

    /*
        Iterate over the given Array
        If a complement based on sum is available in the Hash table return it
        Else if item is not present in HT insert in HT
    */
    class Program
    {
        static void Main(string[] args)
        {
            int targetSum = 20;
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            int[] input = new int[] { 9, 10, 11, 16, 8, 4, 12, 1, 19 };
            HashSet<int> hs = new HashSet<int>();
            int inputLength = input.Length;
            for (int i = 0; i < inputLength; i++)
            {
                int pairNumber = targetSum - input[i];
                if (hs.Contains(pairNumber))
                {
                    pairs.Add(input[i], pairNumber);
                }
                if(!hs.Contains(input[i])){
                    hs.Add(input[i]);
                }
            }
            Console.WriteLine($"Pairs count {pairs.Count}");
            if (pairs.Count > 0)
            {
                foreach (KeyValuePair<int,int> entry in pairs)
                {
                    Console.WriteLine($"{entry} ");
                    Console.WriteLine($"{entry.Key} - {entry.Value} ");
                }
            }
        }
    }
}

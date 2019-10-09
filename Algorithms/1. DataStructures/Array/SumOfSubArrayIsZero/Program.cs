using System;
using System.Collections;
using System.Collections.Generic;

namespace SumOfSubArrayIsZero
{
    class Program
    {
        public class Finder
        {
            // Navigate through all the Possible sub arrays and print when Sum is zero
            // For navigation, for each iteration skip the trailing item
            // O(n^2)
            public void FindByNaive(int[] input)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int sum = 0; // Start adding again from the sub array
                    for (int j = i; j < input.Length; j++)
                    {
                        sum += input[j];
                        if (sum == 0)
                        {
                            Console.WriteLine($"Array from [{i}-{j}]");
                        }
                    }
                }

            }

            // We Keep summing up and store Indexes and Sum till that index
            // If there exists a set of array whole sum is 0 till that index , we would find  the sum to repeat
            // e.g. {1,3,5,-1,-4,8} for this as soon as index is at 1 and 4  we will see a sum to be same 
            public void FindByHashMap(int[] input)
            {
                Dictionary<int, List<int>> sumMapper = new Dictionary<int, List<int>>();

                int sum = 0;
                sumMapper.Add(0, new List<int> { -1 });
                for (int i = 0; i < input.Length; i++)
                {
                    sum += input[i];
                    if (sumMapper.ContainsKey(sum))
                    {
                        var indexes = sumMapper[sum];
                        for (int j = 0; j < indexes.Count; j++)
                        {
                            int indexValue = indexes[j];
                            Console.WriteLine($"Array from [{indexValue + 1}-{i}]");
                        }
                        sumMapper[sum].Add(i);
                    }
                    else
                    {
                        sumMapper.Add(sum, new List<int> { i });
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] input = { 3, 4, -7, 3, 1, 3, 1, -4, -2, -2 };
            Finder finder = new Finder();
            Console.WriteLine("By Naive");
            finder.FindByNaive(input);
            Console.WriteLine("By HashMap");
            finder.FindByHashMap(input);
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace StringPermutation
{
    /* 
    Algorithm:
    Using this method we we be using recursion to find permutations of a given string
    Logic:
    1. Take the String into arry and have the count of the element
    2. Use An array and fill it as we traverse to the next subcall of Find Permutation
    2. As you Branch from the String Pointer, decrement its count
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);

            StringPermutationUtil sp = new StringPermutationUtil();
            var result = sp.permute("AABC".ToCharArray());
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
    class StringPermutationUtil
    {
        public List<String> permute(char[] input)
        {
            Dictionary<char, int> countMap = new Dictionary<char, int>();
            foreach (char ch in input)
            {
                if (countMap.ContainsKey(ch))
                {
                    countMap[ch] = countMap[ch] + 1;
                }
                else
                {
                    countMap.Add(ch, 1);
                }
            }
            char[] str = new char[countMap.Count];
            int[] count = new int[countMap.Count];
            int index = 0;
            foreach (KeyValuePair<char, int> entry in countMap)
            {
                str[index] = entry.Key;
                count[index] = entry.Value;
                index++;
            }
            List<string> resultList = new List<string>();
            char[] result = new char[input.Length];
            permuteUtil(str, count, result, 0, resultList);
            return resultList;
        }

        public void permuteUtil(char[] str, int[] count, char[] result, int level, List<String> resultList)
        {
            if (level == result.Length)
            {
                resultList.Add(new String(result));
                return;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (count[i] == 0)
                {
                    continue;
                }
                result[level] = str[i];
                count[i]--;
                permuteUtil(str, count, result, level + 1, resultList);
                count[i]++;
            }
        }

        private void printArray(char[] input)
        {
            foreach (char ch in input)
            {
                Console.WriteLine(ch);
            }
        }

    }
}

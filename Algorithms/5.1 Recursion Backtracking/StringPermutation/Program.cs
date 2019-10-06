using System;
using System.Collections;
using System.Collections.Generic;

namespace StringPermutation
{
    /* 
    Algorithm:
    Using this method we we be using recursion to find permutations of a given string
    Logic:
    1. Get the string into Array
    2. Generate a string[]  and Count[] which keeps the char and their count
    3. For genrating result we need List<String> to store result Set, 
        a char array of same length which will be filled to ensure we are using all strings
    4. Start permutation with [-,-,-][A,B,C] , [2,1,1] , level 0 , result[]
    5. Keep Track of of Level in recursion to fill in the Result String
    6. Before Each Recursion Call, reduce the count of the char used to pass on to next Level
    7. On Resolution of Recursion, increment the count of the char (Restoring the original Precodition)
    
    */

   // Other way https://www.youtube.com/watch?v=iFafKAUGqrY&list=RDQMKw-qxoCFyyk&index=3
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args[0]);

            StringPermutationUtil sp = new StringPermutationUtil();
            var result = sp.permute("SAABC".ToCharArray());
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
            // 2. Generate a Map of Char -> Count
            foreach (KeyValuePair<char, int> entry in countMap)
            {
                str[index] = entry.Key;
                count[index] = entry.Value;
                index++;
            }
            // Container for List of Permutations
            List<string> resultList = new List<string>();
            char[] result = new char[input.Length];
            //  4. Start permutation with [-,-,-][A,B,C] , [2,1,1] , level 0 , result[]
            permutateString(str, count, result, 0, resultList);
            return resultList;
        }

        public void permutateString(char[] str, int[] count, char[] result, int level, List<String> resultList)
        {
            // 5. Keep Track of of Level in recursion to fill in the Result String
            if (level == result.Length)
            {
                Console.WriteLine(level);
                Console.WriteLine(result.Length);
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
                // 6. Before Each Recursion Call, reduce the count of the char used to pass on to next Level
                count[i]--;
                permutateString(str, count, result, level + 1, resultList);
                // 7. On Resolution of Recursion, increment the count of the char (Restoring the original Precodition)
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

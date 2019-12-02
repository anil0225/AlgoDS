using System;
using System.Collections;
using System.Collections.Generic;

namespace _2.LongesSubstringWithoutRepeatingChars
{
    class Program
    {
        /*
            - Sliding Window Technique
            - Have Two pointers for window i,j
            - i stays at initial position and j keeps moving from left to right and check the max length
            - while j is moving if it encounters duplicate char , move i to next position of duplicate
        */
        static void Main(string[] args)
        {
            int result = LengthOfLongestSubstring("pwkew");
            Console.WriteLine($"Longest substring length without repitions is {result}");
        }

        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length <= 1)
            {
                return s.Length;
            }
            char[] input = s.ToCharArray();
            // Declare Window Pointers
            int i = 0;
            int maxLength = 1;
            int stringLength = input.Length;
            Dictionary<char,int> positionMapper = new Dictionary<char, int>();
            positionMapper.Add(input[0], 0);
            for (int j = 1; j < stringLength; j++)
            {
                int currentMax = 0;
                char currentChar = input[j];
                if (positionMapper.ContainsKey(currentChar) && (positionMapper[currentChar]) >= i)
                {
                    i = positionMapper[currentChar] + 1;
                    currentMax = j - i + 1;
                    maxLength = Math.Max(currentMax, maxLength);
                }
                else
                {
                    currentMax = j - i + 1;
                    maxLength = Math.Max(currentMax, maxLength);
                }
                positionMapper.Remove(currentChar);
                positionMapper.Add(currentChar, j);
            }

            return maxLength;
        }
    }
}

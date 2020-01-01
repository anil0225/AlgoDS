using System;
using System.Collections;
using System.Collections.Generic;

namespace WaterCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bars = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Console.WriteLine($"By Bruteforce {GetWaterCollectedUsingBrutForce(bars)}");
            Console.WriteLine($"By Dynamic {GetWaterCollectedUsingDynamic(bars)}");
            // Console.WriteLine(GetWaterCollectedUsingStack(null));
        }

        /// 1. 3 Pointer, 1 pointer iterates 2 others find Max on right and Max on Left
        /// 2. Once we get maxes we find min of both to find 
        /// 3. Reduce current value from above (2) to find what current column can hold
        static int GetWaterCollectedUsingBrutForce(int[] bars)
        {
            int result = 0;
            int maxLeft = 0, maxRight = 0;
            for (int i = 0; i < bars.Length; i++)
            {
                maxLeft = 0;
                maxRight = 0;
                for (int j = i - 1; j > 0; j--)
                {
                    // Console.WriteLine($"Getting Left Max of {bars[j]}-{maxLeft}");
                    maxLeft = Math.Max(bars[j], maxLeft);
                }
                for (int k = i + 1; k < bars.Length; k++)
                {
                    // Console.WriteLine($"Getting Right Max of {bars[i]}-{maxRight}");
                    maxRight = Math.Max(bars[k], maxRight);
                }

                Console.WriteLine($"Getting Min of Left Right for {i} : {maxLeft}-{maxRight}");
                result += Math.Max(Math.Min(maxLeft, maxRight) - bars[i], 0);
                Console.WriteLine(result);
            }
            return result;
        }


        static int GetWaterCollectedUsingDynamic(int[] bars)
        {
            int result = 0;
            Hashtable maxLeft = new Hashtable();
            Hashtable maxRight = new Hashtable();
            maxLeft.Add(0, bars[0]);
            maxRight.Add(bars.Length - 1, bars[bars.Length - 1]);

            for (int k = 1; k < bars.Length; k++)
            {
                maxLeft.Add(k, Math.Max(bars[k], (int)maxLeft[k - 1] ));
            }

            for (int j = bars.Length - 2; j >= 0; j--)
            {
                maxRight.Add(j, Math.Max(bars[j], (int)maxRight[j + 1]));
            }


            for (int i = 0; i < bars.Length; i++)
            {
                int maxLeftHeight = maxLeft.ContainsKey(i - 1) ? (int)maxLeft[i - 1] : 0;
                int maxRightHeight = maxRight.ContainsKey(i + 1) ? (int)maxRight[i + 1] : 0;

                Console.WriteLine($"Getting Min of Left Right for {i} : {maxLeftHeight}-{maxRightHeight}");
                result += Math.Max(Math.Min(maxLeftHeight, maxRightHeight) - bars[i], 0);
                Console.WriteLine(result);
            }
            return result;
        }

        static int GetWaterCollectedUsingStack(int[] bars)
        {
            return 0;
        }
    }
}

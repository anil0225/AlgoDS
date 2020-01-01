using System;

namespace WaterCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bars = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            Console.WriteLine($"By Bruteforce {GetWaterCollectedUsingBrutForce(bars)}");
            // Console.WriteLine(GetWaterCollectedUsingDynamic(null));
            // Console.WriteLine(GetWaterCollectedUsingStack(null));
        }

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
                    Console.WriteLine($"Getting Left Max of {bars[j]}-{maxLeft}");
                    maxLeft = Math.Max(bars[j], maxLeft);
                }
                for (int k = i + 1; k < bars.Length; k++)
                {
                    Console.WriteLine($"Getting Right Max of {bars[i]}-{maxRight}");
                    maxRight = Math.Max(bars[k], maxRight);
                }

                Console.WriteLine($"Getting Min of Left Right{maxLeft}-{maxRight}");
                result += Math.Max(Math.Min(maxLeft, maxRight) - bars[i], 0);
                Console.WriteLine(result);
            }
            return result;
        }

        static int GetWaterCollectedUsingDynamic(int[] bars)
        {
            return 0;
        }

        static int GetWaterCollectedUsingStack(int[] bars)
        {
            return 0;
        }
    }
}

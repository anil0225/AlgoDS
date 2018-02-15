using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        /// <summary>
        /// Pick a pointer
        /// Everything left of it is sorted
        /// Now Compare Current  with Left of it until the current one is smaller.. left most being big
        /// O(n^2)
        /// Think of arranging cards
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] input = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int length = input.Length;
            Sort(input);
            Console.WriteLine("Insertion Sort");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(input[i]);
            }
            Console.ReadLine();
        }

        private static int[] Sort(int[] input) {
            int length = input.Length;
            for (int i = 1; i < length; i++) //n
            {
                int current = input[i];
                int arrPtr = i - 1;
                while (arrPtr >= 0 && input[arrPtr] > current) {  //max n
                    input[arrPtr + 1] = input[arrPtr];
                    arrPtr--;
                }
                input[arrPtr + 1] = current;
            }
            return input;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    /// <summary>
    /// Start
    /// Compare consequent elements
    /// Push larger one to End on completion of one Cycle pushes largest to End of Array
    /// Iterate  leaving Last element
    /// O(N^2) 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int length = input.Length;
            Sort(input);
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(input[i]);
            }
            Console.ReadLine();
        }

        private static int[] Sort(int[] input)
        {

            int length = input.Length;
            for (int i = 0; i < length - 1; i++) //n
            {
                for (int j = 0; j < length - i - 1; j++) //n
                {
                    if (input[j] > input[j + 1])
                    {

                        Utilities.GeneralUtil.Exchange(input, j, j + 1);
                    }
                }
            }

            return input;
        }
    }
}

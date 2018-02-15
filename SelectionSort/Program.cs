using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int length = input.Length;
            Sort(input);
            Console.WriteLine("Selection Sort");
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(input[i]);
            }
            Console.ReadLine();
        }

        private static int[] Sort(int[] input) {
            int length = input.Length;

            for (int i = 0; i < length; i++)
            {
                //int currentMin = input[i]; can use curren min and swap after for
                for (int j = i+1; j < length; j++)
                {
                    if (input[j] < input[i]) {
                        Utilities.GeneralUtil.Exchange(input, i, j);
                    }
                }

            }

            return input;
        }

    }
}

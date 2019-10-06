using System;

namespace SelectionSort
{
    public class SelectionSort{
        public int[] sort(int[] input){
            Console.WriteLine("Starting to sort");
            
            for (int i = 0; i < input.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < input.Length; j++)
                {
                    if(input[j] < input[minIndex]){
                        minIndex = j;
                    }
                }                
                var temp = input[i];
                input[i] = input[minIndex];
                input[minIndex] = temp;
            }
            return input;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Time for seleciton Sort");
            int[] input = {2,4,1,9,3,66,33,11};
            SelectionSort sorter = new SelectionSort();
            var result = sorter.sort(input);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{input[i]},");
            }

        }
    }
}

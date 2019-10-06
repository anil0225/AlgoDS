using System;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter input Array e.g. 1 2 3 4 5 6");
            string[] input = Console.ReadLine().Split(" ");
            Console.WriteLine("Enter Search Value");
            string searchInput  = Console.ReadLine();

            LinearSearch ls = new LinearSearch();
            int result = ls.Search(input, searchInput);
            if(result > -1){
                Console.WriteLine($"Found item at {result}");
            }else{
                Console.WriteLine("Item not found item");
            }
        }
    }

    public class LinearSearch
    {

        public int Search(string[] inputArray, string inputValue){
            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.WriteLine($"{i} - {inputArray[i]}");
                if(inputArray[i] == inputValue){
                    return i;
                }
            }
            return -1;
        }

    }
}

using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 2, 4, 5, 6, 18, 20 };
            BinarySearch bs = new BinarySearch();
            int index = bs.Search(inputArray, 6, 0, inputArray.Length - 1);

            if (index > -1)
                Console.WriteLine($"Found item at {index}");
            else
                Console.WriteLine("Item not found");
        }
    }

    class BinarySearch
    {
        public int Search(int[] inputArray, int searchValue, int start, int end)
        {
            if (end >= 1)
            {
                int mid = start + (end - start) / 2;
                if (inputArray[mid] == searchValue)
                {
                    return mid;
                }
                if (inputArray[mid] > searchValue)
                {
                    return Search(inputArray, searchValue, start, mid - 1);
                }
                else
                {
                    return Search(inputArray, searchValue, mid + 1, end);
                }
            }
            return -1;
        }
    }
}

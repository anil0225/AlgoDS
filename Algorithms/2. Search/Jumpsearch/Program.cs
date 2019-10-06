using System;

namespace Jumpsearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = { 2, 4, 6, 9, 10, 22, 33, 35 };
            Jumpsearch js = new Jumpsearch();
            int result = js.Search(inputArray, 35);
            if (result > -1)
            {
                Console.WriteLine($"Found item at {result}");
            }
            else
            {
                Console.WriteLine("Item not found");
            }
        }
    }

    class Jumpsearch
    {
        public int Search(int[] inputArray, int searchKey)
        {
            int step = 0;
            int end = 0;

            step = (int)Math.Floor(Math.Sqrt(inputArray.Length));

            end = Math.Min(step, inputArray.Length);
            int start = 0;
            while (inputArray[Math.Min(end , inputArray.Length -1) ] < searchKey)
            {
                start = end;
                end = end + step;

                if (end > inputArray.Length)
                    return -1;
            }

            end = Math.Min(end, inputArray.Length -1);
            if (inputArray[end] == searchKey)
                return end;

            while (searchKey >= inputArray[start])
            {
                if (searchKey == inputArray[start]) { return start; }
                start = start + 1;
                if(start >= end) { return -1;}
            }
            return -1;
        }
    }
}

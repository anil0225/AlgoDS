using System;

namespace SimpleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            Console.WriteLine("Hello World!");
            
            Console.WriteLine(myArray.Length);
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }

            Console.WriteLine("Printing Array!!!");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Printing element at {i}");
                Console.WriteLine(myArray[i]);
            }

            
        }
    }
}

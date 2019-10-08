using System;

namespace SimpleArray
{
    class Program
    {
        static void PrintAarray(int[] input)
        {

        }
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


            Console.WriteLine("Initialize Array");
            int[] newArray = { 1, 2, 3, 4 };

            Console.WriteLine("Multidimensinal Array , specify by Row/Column");
            int[,] multiArray = new int[4, 3];
            multiArray = new int[,] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            Console.WriteLine("Multidimensinal Array");


        }
    }
}

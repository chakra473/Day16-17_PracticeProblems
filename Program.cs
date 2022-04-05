using System;

namespace Day16_17PracticeProb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm problems!");
            int[] arr = { 32, 45, 67, 2, 56, 78, 1, 54, 7 };
            Console.WriteLine("before sorted");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Algorithm obj = new Algorithm();
            obj.bubbleSort(arr);
            Console.WriteLine();
            Console.WriteLine("Sorted array");
            obj.printArray(arr);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17PracticeProb
{
    internal class Algorithm
    {
        public void bubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Prints the array
        public void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}

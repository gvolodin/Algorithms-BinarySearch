using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinareyAlgorytmh
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 1, 3, 5, 7, 9 };
            Console.WriteLine("Index of item 3  = " + BinarySearch(numbers, 3));
            Console.WriteLine("Index of item 0  = " + BinarySearch(numbers, 0));
            Console.ReadKey();

        }
        private static object BinarySearch(int[] arr, int item)
        {

            var minNum = 0;
            var maxNum = arr.Length - 1;

            while (minNum <= maxNum)
            {
                var mid = (minNum + maxNum) / 2;
                var guess = arr[mid];
                if (guess == item)
                    return mid;
                else if (item < guess)
                    maxNum = mid - 1;
                else
                    minNum = mid + 1;
            }
            return "Null";



        }
    }
}

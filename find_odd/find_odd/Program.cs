using System;

namespace find_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int result = FindOdd(arr);
            Console.WriteLine("=" + result);
            Console.ReadLine();
        }
        static int FindOdd(int[] arr)
        {
            int n = 0;

            for (int i = 0;i < arr.Length;i++)
            {
                if (i % 2 == 0)
                {
                    // Do nothing
                }
                else
                {
                    Console.WriteLine(arr[i] + "+");
                    n += arr[i];
                }
            }
            return n;
        }
    }
}

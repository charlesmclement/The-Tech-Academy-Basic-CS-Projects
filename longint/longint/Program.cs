using System;

namespace longint
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 123456789, 123456789, 123456789, 123456789, 123456789, 123456789, 123456789, 123456789 };
            long result = Long(arr);
            Console.WriteLine("= " + result);
            Console.ReadLine();
        }
        static long Long(int[] arr)
        {
            long n = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " +");
                n += arr[i];
            }
            return n;
        }
    }
}
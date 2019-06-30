using System;

namespace stringreverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "asdasdasd";
            Console.Write(str + " reversed is ");
            str = StringReverse(str);
            Console.WriteLine(str);
            Console.ReadLine();
        }
        static string StringReverse(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
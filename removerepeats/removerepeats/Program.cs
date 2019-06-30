using System;
using System.Collections.Generic;

namespace removerepeats
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aabbccddeeffgg";
            RemoveRepeats(str);
            Console.ReadLine();
        }

        static string RemoveRepeats(string str)
        {
            Console.WriteLine(str);
            var removed = new HashSet<char>(str);
            Console.Write("Removed repeating characters: ");
            foreach (char c in removed)
                Console.Write(c);
            return str;
        }
    }
}
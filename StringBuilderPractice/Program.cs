using System;
using System.Text;

namespace StringBuilderPractice
{
    class Program
    {
        static void Main()
        {
            string sig1 = "have ";
            string sig2 = "a good ";
            string sig3 = "one!";
            string sig = (sig1 + sig2 + sig3);
            sig = sig.ToUpper();
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello World,\n");
            sb.Append("I am practicing using StringBuilder.\n");
            sb.Append("It is used to manipulate strings easily.\n");
            sb.Append(sig);
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}

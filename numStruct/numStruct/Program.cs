using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numStruct
{
    public struct Number
    {
        public decimal Amount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number Num = new Number();
            Num.Amount = 3.3m;
            Console.WriteLine(Num.Amount);
            Console.ReadLine();
        }
    }
}

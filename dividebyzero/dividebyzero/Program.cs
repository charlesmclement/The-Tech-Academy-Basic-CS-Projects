using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dividebyzero
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> Numbers = new List<int> { 2, 3, 5, 7, 11 };
                Console.WriteLine("Enter a number:");
                int i = int.Parse(Console.ReadLine());
                foreach (int Number in Numbers)
                {
                    Console.WriteLine(Number / i);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("\n...finally");
                Console.ReadLine();
            }
        }
    }
}

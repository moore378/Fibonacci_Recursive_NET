using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Recursive_NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Fib_Rec_Start(20, 6, 15);
        }

        private static void Fib_Rec_Start(int len, int start, int end)
        {
            if (start > len || len < end)
            {
                Console.WriteLine($"Start is either greater than the specified length or end is less than length");
                return;
            }

            Fib_Rec(0, 1, 1, len, start, end);
            Console.WriteLine();
        }

        private static void Fib_Rec(int a, int b, int counter, int len, int start, int end)
        {
            if(counter <= len)
            {
                if(counter >= start && counter <= end)
                {
                    Console.Write($"{a} ");

                    if (counter >= end)
                    {
                        return;
                    }
                }
                
                Fib_Rec(b, a + b, ++counter, len, start, end);
            }
        }
    }
}

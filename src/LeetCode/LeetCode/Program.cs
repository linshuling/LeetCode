using LeetCode.Arithmetic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ZigZagConversion z = new ZigZagConversion();

            Console.WriteLine(z.Solution("ABCDE", 4));

            Console.ReadKey();
        }
    }
}

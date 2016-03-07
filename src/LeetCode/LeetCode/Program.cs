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
            TwoSum two = new TwoSum();

            int[] first = new int[] { 9, 5, 2, 1, 8 };
            int target = 17;
            int[] result = two.Solution(first, target);

            Console.WriteLine("First Index:{0},Second Index:{1}", result[0], result[1]);

            int[] second = new int[] { -4, -5, 0, 0, 18, 200, 5, 0 };
            target = 11111;
            result = two.Solution(second, target);

            Console.WriteLine("First Index:{0},Second Index:{1}", result[0], result[1]);
            Console.ReadKey();
        }
    }
}

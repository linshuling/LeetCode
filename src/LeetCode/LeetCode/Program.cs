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
            LongestPalindrome l = new LongestPalindrome(); 

            Console.WriteLine(l.Solution("abcba"));
            Console.WriteLine(l.Solution("abcdba"));
            Console.WriteLine(l.Solution("abcbaaa"));
            Console.WriteLine(l.Solution("abcbabb"));
            Console.WriteLine(l.Solution("aaabcba"));
            Console.ReadKey();
        }
    }
}

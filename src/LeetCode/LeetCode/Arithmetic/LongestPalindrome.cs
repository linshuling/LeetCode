using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arithmetic
{
    public class LongestPalindrome
    {
        public string Solution(string s)
        {
            //Danymic Programing O(n*n)
            //Memory Limit Exceeded My God
            int arrLength = s.Length + 1;
            int[,] counts = new int[arrLength, arrLength];

            int max = 0;
            int maxi = 0;

            for (int i = 1; i < arrLength; i++)
            {
                for (int j = 1; j <arrLength ; j++)
                {
                    if(s[i-1] == s[arrLength-j-1])
                    {
                        counts[i, j] = counts[i - 1, j - 1] + 1;

                        if(counts[i,j] > max)
                        {
                            max = counts[i, j];
                            maxi = i;
                        }
                    }
                }
            }

            return s.Substring(maxi - max, max);
        }
    }
}

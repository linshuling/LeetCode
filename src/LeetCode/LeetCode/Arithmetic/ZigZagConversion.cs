using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arithmetic
{
    public class ZigZagConversion
    {
        public string Solution(string s, int numRows)
        {
            char[] chars = new char[s.Length];
            char[] ss = s.ToCharArray();
            int start = 0;

            //firstRow each char is separated by numRow + numRow - 2
            for (int i = 0; i < ss.Length; )
            {
                chars[start] = ss[i];
                start++;
                i = i + numRows * 2 - 2;
            }

            //middle(n-2)Rows each char is separated by numRow - 1
            for (int i = 1; i < numRows - 1; i++)
            {
                for (int j = i; j < ss.Length; )
                {
                    chars[start] = ss[j];
                    start++;
                    j = j + numRows - 1;
                }
            }

            //lastRow each char is separated by numRow + numRow - 2
            for (int i = numRows - 1; i < ss.Length; )
            {
                chars[start] = ss[i];
                start++;
                i = i + numRows * 2 - 2;
            }
            return new string(chars);
        }
    }
}

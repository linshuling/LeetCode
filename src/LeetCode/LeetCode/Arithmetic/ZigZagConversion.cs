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
            //0	 	 	 	8	 	 	 	16	 	 	 n = 1, 2*(numRows-1)
            //1	 	 	7	9	 	 	15	17	 	 	 n = 2, 2*(numRows - n) , 2*(numRows-1)
            //2	 	6	 	10	 	14	 	18	 	 	 ...
            //3	5	 	 	11	13	 	 	19	 	 	 ...
            //4	 	 	 	12	 	 	 	20	 	 	 n = numRows, 2*(numRows-1)
            if (numRows <= 1)
                return s;
            char[] chars = new char[s.Length];
            char[] ss = s.ToCharArray();
            int start = 0;

            for (int n = 1; n <= numRows; n++)
            {
                for (int i = n - 1; i < ss.Length; )
                {
                    chars[start] = ss[i];
                    start++;
                    if ((n != 1 && n != numRows) && (i + 2 * (numRows - n)) < ss.Length)
                    {
                        chars[start] = ss[i + 2 * (numRows - n)];
                        start++;
                    }
                    i = i + 2 * (numRows - 1);
                }
            }

            return new string(chars);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCode.Arithmetic
{
    public class LengthOfLongestSubstring
    {
        //Let me think
        public int Solution(string s)
        {
            char[] chars = s.ToCharArray();

            Hashtable hash = new Hashtable();

            int longest = 0;
            int pos = 0;
            int last = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (hash.ContainsKey(chars[i]))
                {
                    last = (int)hash[chars[i]];
                    //this char after pos  
                    //当前指向的位置和上一个字符的位置可能相等，这被坑了好久
                    if (last >= pos)
                    {
                        //calculate longest
                        longest = longest < (i - pos) ? (i - pos) : longest;

                        //position is next char index
                        pos = (int)hash[chars[i]] + 1;
                    }

                    //update current char's index
                    hash[chars[i]] = i;
                }
                else
                {
                    hash.Add(chars[i], i);
                }
            }
            //Last Characters are not repeating
            longest = longest < s.Length - pos ? s.Length - pos : longest;
            return longest;
        }
    }
}

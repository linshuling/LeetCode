using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace LeetCode.Arithmetic
{
    public class TwoSum
    {
        public int[] Solution(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            int[] result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(nums[i]))
                {
                    result[0] = dic[nums[i]];
                    result[1] = i;
                    return result;
                }

                //Choose First Index
                if (!dic.ContainsKey(target - nums[i]))
                    //The Key is the Second Number
                    dic.Add(target - nums[i], i);
            }

            throw new Exception("Numbers Do Not Exist");
        }
    }
}

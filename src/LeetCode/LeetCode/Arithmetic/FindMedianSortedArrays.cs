using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Arithmetic
{
    public class FindMedianSortedArrays
    {
        //O((m+n)/2)
        public double Solution(int[] nums1, int[] nums2)
        {
            int len1 = nums1.Length;
            int len2 = nums2.Length;
            int middle = (len1 + len2) / 2;
            int[] newnums = new int[middle + 1];
            int index = 0;
            int i = 0;
            int j = 0;
            while (index <= middle)
            {
                if (i < len1 && j < len2)
                {
                    if (nums1[i] <= nums2[j])
                    {
                        newnums[index] = nums1[i];
                        i++;
                    }
                    else
                    {
                        newnums[index] = nums2[j];
                        j++;
                    }
                }
                else if (i == len1)
                {
                    newnums[index] = nums2[j];
                    j++;
                }
                else
                {
                    newnums[index] = nums1[i];
                    i++;
                }

                index++;
            }

            double result = 0;
            if ((len1 + len2) % 2 == 0)
            {
                result = (newnums[middle] + newnums[middle - 1]) * 0.5;
            }
            else
            {
                result = newnums[middle];
            }
            return result;
        }
    }
}

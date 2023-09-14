using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.arrays_and_hashing
{
    public class LongestConsecutiveSequence
    {
        public int Solution(int[] nums)
        {
            HashSet<int> set = new HashSet<int>(nums);
            int longest = 0;
            foreach (var num in nums)
            {
                if (!set.Contains(num - 1))
                {
                    int length = 0;
                    while (set.Contains(num + length))
                    {
                        length++;
                    }

                    longest = Math.Max(longest, length);
                }
            }

            return longest;
        }
    }
}

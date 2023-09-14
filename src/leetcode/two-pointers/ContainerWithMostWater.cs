using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.two_pointers
{
    public class ContainerWithMostWater
    {
        public int Solution(int[] height)
        {
            var res = 0;
            int left = 0;
            int right = height.Length - 1;

            while (left < right)
            {
                var area = (right - left) * Math.Min(height[left], height[right]);
                res = Math.Max(res, area);

                if (height[left] < height[right])
                {
                    left++;
                }
                else if (height[left] >= height[right])
                {
                    right--;
                }
            }

            return res;
        }
    }
}

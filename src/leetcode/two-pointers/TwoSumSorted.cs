using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.two_pointers
{
    public class TwoSumSorted
    {
        public int[] Solution(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            int[] res = new int[2];
            while (left <= right)
            {
                if (numbers[left] + numbers[right] < target)
                {
                    left++;
                }
                else if (numbers[left] + numbers[right] > target)
                {
                    right--;
                }
                else
                {
                    res[0] = left + 1;
                    res[1] = right + 1;
                    break;
                }
            }

            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.two_pointers
{
    public class ThreeSum
    {
        
        public IList<IList<int>> Solution(int[] nums)
        {
            int left, right;
            IList<IList<int>> res = new List<IList<int>>();
            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (i != 0 && nums[i] == nums[i - 1]) continue;
                left = i + 1;
                right = nums.Length - 1;

                while (left < right)
                {
                    var threeSum = nums[left] + nums[right] + nums[i];
                    if (threeSum > 0)
                    {
                        right--;
                    }
                    else if (threeSum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        res.Add(new List<int> { nums[i], nums[left], nums[right] });
                        left++;
                        while (nums[left] == nums[left - 1] && left < right) left++;
                    }
                }
            }

            return res;
        }
    }
}

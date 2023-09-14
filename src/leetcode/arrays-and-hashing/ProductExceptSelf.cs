using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.arrays_and_hashing
{
    public class ProductExceptSelf
    {
        public int[] Solution(int[] nums)
        {
            int[] prefixArr = new int[nums.Length];
            int[] postfixArr = new int[nums.Length];

            int prefix = 1;
            int postfix = 1;

            for(var i = 0; i < nums.Length; i++)
            {

                prefixArr[i] = prefix;
                prefix = prefix * nums[i];
            }


            for(var i = nums.Length - 1; i >= 0; i--)
            {
                prefixArr[i] = prefixArr[i] * postfix;
                postfix = postfix * nums[i];
            }
            return prefixArr;
        }
    }
}

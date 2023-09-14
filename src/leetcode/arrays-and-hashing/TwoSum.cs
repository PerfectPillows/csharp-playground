using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.arrays_and_hashing
{
    public class TwoSum
    {
        public int[] solution(int[] nums, int target)
        {
            int[] res = new int[2];
            Dictionary<int,int> map = new Dictionary<int,int>();

            for(int i = 0; i < nums.Length;i++)
            {
                int diff =  target - nums[i];
                if(map.ContainsKey(diff))
                {
                    
                    res[0] = map[diff];
                    res[1] = i;
                    break;
                }
                map[nums[i]] = i;
            }
            return res;
        }
    }
}

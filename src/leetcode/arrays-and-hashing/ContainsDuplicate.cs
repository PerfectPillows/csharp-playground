using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.arrays_and_hashing
{
    public class ContainsDuplicate
    {
        public bool solution(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();
            foreach(int num in nums)
            {
                if(set.Contains(num))
                {
                    return true;
                }
                else { set.Add(num); }
            }

            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.arrays_and_hashing
{
    public class TopKFrequentElements
    {
        public static int[] Solution(int[] nums, int k)
        {
            int[] res = new int[k];
            var dict = new Dictionary<int, int>();  
            //creating a dictionary with the frequency
            for(int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    dict[nums[i]]++;
                }
                else
                {
                    dict.Add(nums[i], 1);
                }
            }

            // adding the elements into the priority queue
            // api - key and priority
            var pq = new PriorityQueue<int, int>();
            foreach (var key in dict.Keys)
            {
                //adding the key and the frequency as the priority
                pq.Enqueue(key, dict[key]);
                if (pq.Count > k) pq.Dequeue();
            }
            int i2 = k;
            while (pq.Count > 0)
            {
                res[--i2] = pq.Dequeue();
            }
            return res;

        }
    }
}

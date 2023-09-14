using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.arrays_and_hashing
{
    public class GroupAnagrams
    {
        public IList<IList<string>> solution(string[] strs)
        {
            IList<IList<string>> res = new List<IList<string>>();
            Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();

            foreach (string str in strs) { 
                var strCopy = new String(str.OrderBy(c => c).ToArray());
                if(!map.ContainsKey(strCopy))
                {   var newList = new List<string>();
                    newList.Add(str);
                    map.Add(strCopy, newList);
                }
                else
                {
                    map[strCopy].Add(str);
                }
            }

            foreach(var key in map.Keys)
            {
                res.Add(map[key]);
            }

            return res;
        }


        public IList<IList<string>> solution_optimized(string[] strs)
        {
            IList<IList<string>> res = new List<IList<string>>();
            Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();

            foreach (string str in strs)
            {
                char[] hash = new char[26];
                foreach(char c in str)
                {
                    hash[c - 'a']++;
                }

                string key = new string(hash);
                if (!map.ContainsKey(key))
                {
                    var newList = new List<string>();
                    newList.Add(str);
                    map.Add(key, newList);
                }
                else
                {
                    map[key].Add(str);
                }
            }

            return map.Values.ToList();
        }
    }
}

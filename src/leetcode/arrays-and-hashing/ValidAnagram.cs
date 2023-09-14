using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.arrays_and_hashing
{
    public class ValidAnagram
    {
        public bool solution(string s, string t)
        {
            //the solution is to sort the strings and compare them 
            return new String(s.OrderBy(c => c).ToArray()) == new string(t.OrderBy(c => c).ToArray());
        }
    }
}

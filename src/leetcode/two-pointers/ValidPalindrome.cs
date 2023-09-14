using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace leetcode.two_pointers
{
    public class ValidPalindrome
    {
        public bool Solution(string s)
        {
            string cleaned = Regex.Replace(s, "[^a-zA-Z0-9]", "");
            cleaned = cleaned.ToLower();
            int left = 0;
            int right = cleaned.Length - 1;

            while (left <= right)
            {
                if (cleaned[left] != cleaned[right]) return false;
                left++;
                right--;
            }
            return true;
            
        }
    }
}

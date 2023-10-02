using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.practice
{
    public class ReverseWords
    {
        public string Solution(string s)
        {
            string[] strings = s.Split(" ");
            StringBuilder sb = new StringBuilder();
            foreach (var str in strings)
            {
                sb.Append(this.Reverse(str));
                sb.Append(' ');
            }

            return sb.ToString().Substring(0,sb.Length - 1);
        }


        public string Reverse(string s)
        {
            StringBuilder sb = new StringBuilder(s);
            int left = 0;
            int right = sb.Length - 1;

            while (left < right)
            {
                char temp = sb[left];
                sb[left] = sb[right];
                sb[right] = temp;
                left++;
                right--;
            }

            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.arrays_and_hashing
{
    public class EncodeDecodeStrings
    {
        public String encode(List<String> strs)
        {
            StringBuilder sb = new StringBuilder();
            foreach (String str in strs) { 
                sb.Append(str.Length + "#" + str);
            }

            return sb.ToString();
        }

       
        public List<String> decode(String str)
        {
           List<String> res = new List<String>();
           int i = 0;
           while (i < str.Length)
            {
                int j = i;
                while (str[j] != '#')
                {
                    j++;
                }
                int length = Int32.Parse(str.Substring(i, j - i));
                res.Add(str.Substring(j+1,length));

                i = j + 1 + length;
            }

            return res;
        }
    }
}

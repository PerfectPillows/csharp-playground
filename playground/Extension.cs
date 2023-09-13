using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_playground.playground
{
    public static class Extension
    {
        public static List<T> Filter<T>(this List<T> records, Func<T, bool> func)
        {
            List<T> result = new List<T>();
            foreach(T record in records)
            {
                if (func(record))
                {
                    result.Add(record);
                }
            }

            return result;
        }


        public static string CapitalizeSentence(this string str)
        {
            if(str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            string res = "";
            string[] tokens = str.Split(" ");
            foreach(string token in tokens)
            {
                res += char.ToUpper(token[0]) + token.Substring(1) + " ";
            }
            return res;
        }
    }
}

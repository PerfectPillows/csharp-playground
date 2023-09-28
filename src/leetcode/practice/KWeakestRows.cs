using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.practice
{
    public class KWeakestRows
    {
        public int[] Solution(int[][] mat, int k)
        {
            List<int> res = new List<int>();
            List<(int index, int strength)> strength = new List<(int index, int strength)>();
            for (var i = 0; i < mat.Length; i++)
            {
                var rowStrength = 0;
                for (var j = 0; j < mat[0].Length; j++)
                {
                    if (mat[i][j] == 1) rowStrength++;
                }

                strength.Add((i, rowStrength));
            }

            strength.Sort((x, y) =>
            {
                if (x.strength == y.strength)
                {
                    return x.index.CompareTo(y.index);
                }
                return x.strength.CompareTo(y.strength);
            });

            for(var i = 0; i < k; i++)
            {
                res.Add(strength[i].index);
            }

            return res.ToArray();
        }
    }
}

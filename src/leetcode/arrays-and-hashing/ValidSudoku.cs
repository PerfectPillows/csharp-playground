using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.arrays_and_hashing
{
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            var rowSet = new Dictionary<int, HashSet<char>>();
            var colSet = new Dictionary<int, HashSet<char>>();
            var squareSet = new Dictionary<(int, int), HashSet<char>>();

            for(var r = 0; r < 9; r++)
            {
                rowSet[r] = new HashSet<char>();
                for(var c = 0; c < 9; c++)
                {
                    //Initialize the sets 
                    if (!colSet.ContainsKey(c)) colSet[c] = new HashSet<char>();
                    if (!squareSet.ContainsKey((r / 3 , c / 3))) squareSet[(r / 3, c / 3)] = new HashSet<char>();

                    //conditions to check 
                    if (board[r][c] == '.') continue;
                    if (rowSet[r].Contains(board[r][c]) || 
                        colSet[c].Contains(board[r][c]) || 
                        squareSet[(r / 3, c / 3)].Contains(board[r][c]))
                    {
                        return false;
                    }

                    //add the elements if not there 
                    rowSet[r].Add(board[r][c]);
                    colSet[c].Add(board[r][c]);
                    squareSet[(r/3, c / 3)].Add(board[r][c]);
                }
            }

            return true;
        }
    }
}

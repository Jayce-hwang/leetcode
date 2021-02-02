using System;
using System.Text;

namespace LeetCode
{
    // LeetCode 1678. Goal Parser Interpretation
    // https://leetcode.com/problems/goal-parser-interpretation/
    public class N_1678
    {
        public string Interpret(string command)
        {
            return command.Replace("()", "o").Replace("(al)", "al");
        }
    }
}

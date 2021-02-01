using System;

namespace LeetCode
{
    // LeetCode 9. Paalindrome Number
    // https://leetcode.com/problems/palindrome-number/
    public class N_0009
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
            {
                return false;
            }
            else if (x == 0)
            {
                return true;
            }

            int[] NumberAry = NumberBreakDown(x);
            for (int i = 0; i <= NumberAry.Length / 2; i++)
            {
                if (NumberAry[i] != NumberAry[NumberAry.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        private int[] NumberBreakDown(int x)
        {
            int TotalDigits = GetTotalDigits(x);
            int[] NumberAry = new int[TotalDigits];

            for (int i = TotalDigits - 1; i > 0; i--)
            {
                int pow = (int)Math.Pow(10, i);
                NumberAry[TotalDigits - i - 1] = (int)(x / pow);
                x %= pow;
            }

            NumberAry[TotalDigits - 1] = x;

            return NumberAry;
        }

        private int GetTotalDigits(int x)
        {
            return (int)Math.Log10(x) + 1;
        }
    }
}

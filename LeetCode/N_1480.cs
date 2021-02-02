using System;

namespace LeetCode
{
    // LeetCode 1480. Running Sum of 1d Array
    // https://leetcode.com/problems/running-sum-of-1d-array/
    public class N_1480
    {
        public int[] RunningSum(int[] nums)
        {
            int[] res = new int[nums.Length];

            res[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                res[i] = res[i - 1] + nums[i];
            }

            return res;
        }
    }
}

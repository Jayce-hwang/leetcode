using System;

namespace LeetCode
{
    // LeetCode 1108. Defanging an IP Address
    // https://leetcode.com/problems/defanging-an-ip-address/
    public class N_1108
    {
        public string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}

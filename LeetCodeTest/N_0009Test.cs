using LeetCode;
using Xunit;

namespace LeetCodeTest
{
    public class N_0009Test
    {
        [Fact]
        public void LeetCodeExample1()
        {
            bool output = new N_0009().IsPalindrome(121);
            Assert.True(output);
        }

        [Fact]
        public void LeetCodeExample2()
        {
            bool output = new N_0009().IsPalindrome(-121);
            Assert.False(output);
        }

        [Fact]
        public void LeetCodeExample3()
        {
            bool output = new N_0009().IsPalindrome(10);
            Assert.False(output);
        }

        [Fact]
        public void LeetCodeExample4()
        {
            bool output = new N_0009().IsPalindrome(-101);
            Assert.False(output);
        }
    }
}

using LeetCode;
using Xunit;

namespace LeetCodeTest
{
    public class N_1480Test
    {
        [Fact]
        public void LeetCodeExample1()
        {
            int[] output = new N_1480().RunningSum(new int[] { 1, 2, 3, 4 });
            Assert.Equal(output, new int[] { 1, 3, 6, 10 });
        }

        [Fact]
        public void LeetCodeExample2()
        {
            int[] output = new N_1480().RunningSum(new int[] { 1, 1, 1, 1, 1 });
            Assert.Equal(output, new int[] { 1, 2, 3, 4, 5 });
        }

        [Fact]
        public void LeetCodeExample3()
        {
            int[] output = new N_1480().RunningSum(new int[] { 3, 1, 2, 10, 1 });
            Assert.Equal(output, new int[] { 3, 4, 6, 16, 17 });
        }
    }
}

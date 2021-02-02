using LeetCode;
using Xunit;

namespace LeetCodeTest
{
    public class N_1108Test
    {
        [Fact]
        public void LeetCodeExample1()
        {
            string output = new N_1108().DefangIPaddr("1.1.1.1");
            Assert.Equal("1[.]1[.]1[.]1", output);
        }

        [Fact]
        public void LeetCodeExample2()
        {
            string output = new N_1108().DefangIPaddr("255.100.50.0");
            Assert.Equal("255[.]100[.]50[.]0", output);
        }
    }
}

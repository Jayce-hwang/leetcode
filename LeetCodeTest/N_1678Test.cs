using LeetCode;
using Xunit;

namespace LeetCodeTest
{
    public class N_1678Test
    {
        [Fact]
        public void LeetCodeExample1()
        {
            string output = new N_1678().Interpret("G()(al)");
            Assert.Equal("Goal", output);
        }

        [Fact]
        public void LeetCodeExample2()
        {
            string output = new N_1678().Interpret("G()()()()(al)");
            Assert.Equal("Gooooal", output);
        }

        [Fact]
        public void LeetCodeExample3()
        {
            string output = new N_1678().Interpret("(al)G(al)()()G");
            Assert.Equal("alGalooG", output);
        }
    }
}

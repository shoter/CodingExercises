using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson7a
{
    public class Test
    {
        Codility.Lessons.Lesson7a.Solution s = new Lessons.Lesson7a.Solution();

        [Theory]
        [InlineData("{[()()]}", 1)]
        [InlineData("([)()]", 0)]
        [InlineData("()()[]{}[]()()()()()", 1)]
        [InlineData(")", 0)]
        [InlineData("{)", 0)]
        [InlineData(")(", 0)]
        [InlineData("())()", 0)]
        public void test(string S, int R)
        {
            Assert.Equal(R, s.solution(S));
        }


    }
}

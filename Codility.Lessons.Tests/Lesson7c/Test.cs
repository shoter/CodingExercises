using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson7c
{
    public class Test
    {
        Codility.Lessons.Lesson7c.Solution s = new Lessons.Lesson7c.Solution();

        [Theory]
        [InlineData("(()(())())", 1)]
        [InlineData("())",0)]
        [InlineData(")", 0)]
        [InlineData("(", 0)]
        [InlineData("()(())()", 1)]
        [InlineData("", 1)]
        [InlineData("((()))(", 0)]
        [InlineData(")()(", 0)]
        [InlineData(")(", 0)]
        [InlineData("((())))", 0)]

        public void test(string S, int R)
        {
            Assert.Equal(R, s.solution(S));
        }
        
    }
}

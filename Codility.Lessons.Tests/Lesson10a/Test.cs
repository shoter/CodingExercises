using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson10a
{
    public class Test
    {
        Codility.Lessons.Lesson10a.Solution s = new Lessons.Lesson10a.Solution();
        [Theory]
        [InlineData(24, 8)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 2)]
        public void test(int N, int R)
        {
            Assert.Equal(R, s.solution(N));
        }

        [Theory]
        [InlineData(24, 8)]
        [InlineData(1, 1)]
        [InlineData(2, 2)]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 2)]
        public void bruteTest(int N, int R)
        {
            Assert.Equal(R, s.brute(N));
        }

        [Fact]
        public void big()
        {
            for(int i = int.MaxValue; i > int.MaxValue - 5; --i)
            {
                s.solution(i);
            }
        }

        [Fact]
        public void autoCheck()
        {
            for(int x =1; x < 100; ++ x)
            {
                Assert.Equal(s.brute(x), s.solution(x));

            }
        }

    }
}

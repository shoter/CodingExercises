using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson10c
{
    public class Test
    {
        Codility.Lessons.Lesson10c.Solution s = new Lessons.Lesson10c.Solution();

        [Theory]
        [InlineData(30, 22)]
        public void test(int N, int R)
        {
            Assert.Equal(R, s.solution(N));
        }

        [Theory]
        [InlineData(30, 22)]
        public void bruteTest(int N, int R)
        {
            Assert.Equal(R, s.brute(N));
        }

        [Fact]
        public void big()
        {
            s.solution(1_000_000_000);
        }

        [Fact]
        public void autoCheck()
        {
            for(int x = 1; x <= 100; ++ x)
            {
                Assert.Equal(s.brute(x), s.solution(x));
            }
        }

    }
}

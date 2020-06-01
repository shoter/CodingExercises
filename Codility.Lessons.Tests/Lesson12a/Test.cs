using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson12a
{
    public class Test
    {
        Codility.Lessons.Lesson12a.Solution s { get; } = new Lessons.Lesson12a.Solution();

        [Theory]
        [InlineData(10, 4, 5)]
        public void test(int N, int M, int R) => Assert.Equal(R, s.solution(N, M));

        [Theory]
        [InlineData(10, 4, 5)]
        public void bruteTest(int N, int M, int R) => Assert.Equal(R, s.brute(N, M));

        [Fact]
        public void autoCheck()
        {
            for(int n = 1; n <= 1000; ++n)
            {
                for(int m = 1; m <= 1000; ++m)
                {
                    Assert.Equal(s.brute(n, m), s.solution(n, m));
                }
            }
        }

        [Fact]
        public void lastIndexCheck()
        {
            for (int n = 1; n <= 100; ++n)
            {
                for (int m = 1; m <= 100; ++m)
                {
                    Assert.Equal(0, s.lastIndex(n, m));
                }
            }
        }

        [Fact]
        public void big()
        {
            s.solution(1_000_000_000, 1_000_000_000);
        }

        [Fact]
        public void big2()
        {
            s.solution(1_000_000_002, 1_000_000_001);
        }




    }
}

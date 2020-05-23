using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson5a
{
    public class Test
    {
        Codility.Lessons.Lesson5a.Solution s = new Lessons.Lesson5a.Solution();

        [Theory]
        [InlineData(6,11,2,3)]
        [InlineData(0, 0, 1, 1)]
        [InlineData(0, 0, 1235412, 1)]
        [InlineData(2, 7, 3, 2)]
        [InlineData(2, 6, 3, 2)]
        [InlineData(2, 8, 3, 2)]
        [InlineData(2, 9, 3, 3)]
        [InlineData(0, 5, 3, 2)]
        [InlineData(0, 6, 3, 3)]
        [InlineData(0, 7, 3, 3)]
        [InlineData(0, 8, 3, 3)]
        [InlineData(0, 9, 3, 4)]
        [InlineData(0, 10, 3, 4)]
        [InlineData(0, 11, 3, 4)]
        [InlineData(0, 12, 3, 5)]


        public void test(int A, int B, int K, int R)
        {
            Assert.Equal(R, s.solution(A, B, K));
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]


        public void big(int K)
        {
            s.solution(0, 2_000_000_000, K);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]



        public void bigChecked(int K)
        {
            for (int start = 0; start < 1000; ++start)
            {
                int r = s.solution(0, 2_000, K);
                int m = 0;

                for (int i = 0; i <= 2_000; ++i)
                {
                    if (i % K == 0)
                        m++;
                }
                Assert.Equal(m, r);
            }
        }


    }
}

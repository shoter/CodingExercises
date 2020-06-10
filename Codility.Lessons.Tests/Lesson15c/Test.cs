using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson15c
{
    public class Test
    {
        Codility.Lessons.Lesson15c.Solution s = new Lessons.Lesson15c.Solution();

        [Theory]
        [InlineData(new int[] { 10, 2, 5, 1, 8, 12 }, 4)]
        [InlineData(new int[] { 4, 5, 3 }, 1)]
        [InlineData(new int[] { 4, 5 }, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 4 }, 0)]
        [InlineData(new int[] { 6, 6, 4, 5 }, 4)]
        [InlineData(new int[] { 6, 3, 1, 6 }, 2)]

        public void test(int[] A, int R)
        {
            Assert.Equal(R, s.solution(A));
        }

        [Fact]
        public void autoCheck()
        {
            for (int x = 0; x <= 50; ++x)
            {
                for (int j = 0; j < 10; ++j)
                {
                    int[] A = new int[x];
                    Random r = new Random();
                    for (int i = 0; i < x; ++i)
                        A[i] = r.Next(1, x * 2);

                    Assert.Equal(s.brute(A), s.solution(A));
                }
            }
        }

        [Fact]
        public void big()
        {

            for (int x = 0; x <= 10; ++x)
            {
                int[] A = new int[1000];
                Random r = new Random();
                for (int i = 0; i < 1000; ++i)
                    A[i] = r.Next(1, 1_000_000);

                s.solution(A);

            }
        }

        [Theory]
        [InlineData(new int[] { 10, 2, 5, 1, 8, 12 }, 4)]
        [InlineData(new int[] { 6,3,1,6}, 2)]

        public void bruteTest(int[] A, int R)
        {
            Assert.Equal(R, s.brute(A));
        }

    }
}

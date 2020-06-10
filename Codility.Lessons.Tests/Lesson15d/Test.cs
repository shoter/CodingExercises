using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson15d
{
    public class Test
    {
        Codility.Lessons.Lesson15d.Solution s = new Lessons.Lesson15d.Solution();
        [Theory]
        [InlineData(new int[] { 1, 4, -3 }, 1)]
        [InlineData(new int[] { -8, 4, 5, -10, 3 }, 3)]
        public void test(int[] A, int R)
        {
            Assert.Equal(R, s.solution(A));
        }

        [Fact]
        public void autoCheck()
        {
            for (int x = 1; x < 100; ++x)
            {
                for (int j = 105; j > x; --j)
                {
                    int[] A = new int[x];
                    Random r = new Random();
                    for (int i = 0; i < x; ++i)
                        A[i] = r.Next(-50, 50);

                    Assert.Equal(s.brute(A), s.solution(A));
                }
            }
        }

        [Fact]
        public void big()
        {
            for (int x = 1; x < 10; ++x)
            {
                int[] A = new int[100_000];
                Random r = new Random();
                for (int i = 0; i < A.Length; ++i)
                    A[i] = r.Next(-100, 100);
                s.solution(A);
            }
        }

        [Theory]
        [InlineData(new int[] { 1, 4, -3 }, 1)]
        [InlineData(new int[] { -8, 4, 5, -10, 3 }, 3)]
        public void bruteTest(int[] A, int R)
        {
            Assert.Equal(R, s.brute(A));
        }



    }
}

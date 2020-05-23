using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson5c
{
    public class Test
    {
        Codility.Lessons.Lesson5c.Solution s = new Lessons.Lesson5c.Solution();

        [Theory]
        [InlineData(new int[] { 4, 2, 2, 5, 1, 5, 8 }, 1)]
        [InlineData(new int[] { 4, 2, 2, 5, 9, 1, 1 }, 5)]
        [InlineData(new int[] { 1, 1, 2, 5, 1, 5, 8 }, 0)]
        public void test(int[] A,int R)
        {
            Assert.Equal(R, s.solution(A));
        }

        [Theory]
        [InlineData(new int[] { 4, 2, 2, 5, 1, 5, 8 }, 1)]
        [InlineData(new int[] { 4, 2, 2, 5, 9, 1, 1 }, 5)]
        [InlineData(new int[] { 1, 1, 2, 5, 1, 5, 8 }, 0)]

        public void brute(int[] A, int R)
        {
            Assert.Equal(R, s.brute(A));
        }

        [Fact]
        public void big()
        {
            int size = 100_000;
            int[] A = new int[size];
            Random r = new Random();
            for(int i = 0; i <size;++i)
            {
                A[i] = r.Next(-10_000, 10_000);
            }

            s.solution(A);
        }

        [Fact]
        public void bigCheck()
        {
            for (int x = 0; x < 100; ++x)
            {
                int size = 100;
                int[] A = new int[size];
                Random r = new Random();
                for (int i = 0; i < size; ++i)
                {
                    A[i] = r.Next(-10_000, 10_000);
                }

                Assert.Equal(s.brute(A), s.solution(A));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson4c
{
    public class Test
    {
        Codility.Lessons.Lesson4c.Solution s = new Lessons.Lesson4c.Solution();

        [Theory]
        [InlineData(new int[] { 1, 2, 3}, 4)]
        [InlineData(new int[] { 1, 3, 6, 4, 1,2 },  5)]
        [InlineData(new int[] { 4, 3, 1, 2 }, 5)]
        [InlineData(new int[] { 2, 4, 3, 1 }, 5)]

        [InlineData(new int[] { -1, -3 }, 1)]
        [InlineData(new int[] { 0 }, 1)]
        [InlineData(new int[] { 1 }, 2)]
        [InlineData(new int[] { 2 }, 1)]
        [InlineData(new int[] { 1_000_000 }, 1)]
        [InlineData(new int[] { -1_000_000 }, 1)]
        public void test(int[] A, int R)
        {
            Assert.Equal(R, s.solution(A));
        }

        [Fact]
        public void big()
        {
            int[] A = new int[100_000];
            for (int i = 0; i < A.Length; ++i)
                A[i] = i + 1;

            Assert.Equal(100_001, s.solution(A));

        }

        [Fact]
        public void big2()
        {
            int[] A = new int[100_000];
            Random rand = new Random();
            for (int i = 0; i < A.Length; ++i)
                A[i] = rand.Next(0, 1_000_000);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson4b
{
    public class Test
    {
        Codility.Lessons.Lesson4b.Solution s { get; } = new Lessons.Lesson4b.Solution();

        [Theory]
        [InlineData(5, new int[] { 3, 4, 4, 6, 1, 4, 4 }, new int[] { 3, 2, 2, 4, 2 })]
        [InlineData(1, new int[] { 2 }, new int[] { 0 })]
        [InlineData(1, new int[] { 1 }, new int[] { 1 })]
        [InlineData(1, new int[] { 1, 2 }, new int[] { 1 })]
        [InlineData(1, new int[] { 2, 1 }, new int[] { 1 })]
        [InlineData(2, new int[] { 1, 1, 3 }, new int[] { 2, 2 })]
        [InlineData(2, new int[] { 1, 1, 2 }, new int[] { 2, 1 })]
        [InlineData(2, new int[] { 1, 1, 2, 3 }, new int[] { 2, 2 })]
        [InlineData(3, new int[] { 1, 1, 2, 4 }, new int[] { 2, 2, 2 })]
        [InlineData(3, new int[] { 1, 1, 3, 4 }, new int[] { 2, 2, 2 })]
        public void test(int N, int[] A, int[] R)
        {
            Assert.Equal(R, s.solution(N, A));
        }

        [Fact]
        public void big()
        {
            Random r = new Random();
            int N = 100_000;
            int[] A = new int[N];
            for (int i = 0; i < A.Length; ++i)
            {
                A[i] = r.Next(1, N + 2);
                A[i] = N + 1;
            }

            s.solution(N, A);
        }
    }
}

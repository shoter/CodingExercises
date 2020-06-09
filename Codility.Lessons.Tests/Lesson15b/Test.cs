using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson15b
{
    public class Test
    {
        Codility.Lessons.Lesson15b.Solution s { get; } = new Lessons.Lesson15b.Solution();

        [Theory]
        [InlineData(6, new int[] { 3, 4, 5, 5, 2}, 9)]
        [InlineData(6, new int[] { 6 }, 1)]
        [InlineData(6, new int[] { 6, 6, 6 }, 3)]
        [InlineData(6, new int[] { 6, 6, 2 }, 4)]
        [InlineData(6, new int[] { 6, 6, 2, 2 }, 5)]


        public void test(int M, int [] A, int R)
        {
            Assert.Equal(R, s.solution(M, A));
        }

        [Fact]
        public void big()
        {
            int sum = 0;

            for(int i = 0;i < 100_000; ++i)
            {
                sum += (100_000) - i;
            }

            int[] A = new int[100_000];
            for (int i = 0; i < 100_000; ++i)
                A[i] = i;

            Assert.Equal(sum, s.solution(99_999, A));
        }
        
    }
}

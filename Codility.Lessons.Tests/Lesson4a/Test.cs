using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson4a
{
    public class Test
    {
        Codility.Lessons.Lesson4a.Solution s { get; }  = new Lessons.Lesson4a.Solution();

        [Theory]
        [InlineData(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4}, 6)]
        [InlineData(1, new int[] { 1 }, 0)]
        [InlineData(1, new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 0)]
        [InlineData(2, new int[] { 2, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, 1)]
        [InlineData(2, new int[] { 2 }, -1)]
        [InlineData(2, new int[] { 1 }, -1)]
        [InlineData(3, new int[] { 1, 3, 1, 3, 2, 2 }, 4)]
        [InlineData(3, new int[] { 1, 1, 3, 3, 2 }, 4)]
        [InlineData(3, new int[] { 3, 3, 1, 1, 2 }, 4)]
        [InlineData(3, new int[] { 2, 1, 3, 2, 1 }, 2)]
        public void test(int X, int[] A, int R)
        {
            Assert.Equal(R, s.solution(X, A));
        }

        [Fact]
        public void big()
        {
            int X = 100_000;
            int[] A = new int[X];
            Random rand = new Random();

            for(int i = 0;i < A.Length; ++i)
            {
                A[i] = rand.Next(1, X + 1);
            }

            s.solution(X, A);
        }

        
    }
}

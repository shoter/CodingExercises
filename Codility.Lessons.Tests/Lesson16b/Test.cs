using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson16b
{
    public class Test
    {
        Codility.Lessons.Lesson16b.Solution s { get; } = new Lessons.Lesson16b.Solution();

        [Theory]
        [InlineData(4, new int[] { 1, 2, 3, 4, 1, 1, 3 }, 3)]
        [InlineData(6, new int[] { 8, 4, 4, 3, 3, 1, 4, 3 }, 4)]
        [InlineData(6, new int[] { 6 }, 1)]
        [InlineData(6, new int[] { 5 }, 0)]
        [InlineData(1_000_000_000, new int[] { 999_999_999, 999_999_999, 999_999_999}, 1)]


        public void test(int K, int [] A, int R)
        {
            Assert.Equal(R, s.solution(K, A));
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codility.Lessons.Lesson3c;
using Xunit;

namespace Codility.Lessons.Tests.Lesson3c
{
    public class Test
    {
        Solution s { get; } = new Solution();

        [Theory]
        [InlineData(1, new int[] { 3, 1, 2, 4, 3})]
        [InlineData(0, new int[] { 5, 5 })]
        [InlineData(3, new int[] { 1, -2})]
        [InlineData(3, new int[] { -3, 2, -5, 7 })]

        public void test(int r, int[] A)
        {
            Assert.Equal(r, s.solution(A));
        }
        
    }
}

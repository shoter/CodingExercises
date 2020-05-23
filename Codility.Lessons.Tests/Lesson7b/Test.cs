using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson7b
{
    public class Test
    {
        Codility.Lessons.Lesson7b.Solution s = new Lessons.Lesson7b.Solution();

        [Theory]
        [InlineData(new int[] { 4, 3, 2, 1, 5 }, new int[] { 0, 1, 0, 0, 0 }, 2)]
        [InlineData(new int[] { 1 }, new int[] { 0 }, 1)]
        [InlineData(new int[] { 1, 2 }, new int[] { 0, 1 }, 2)]
        [InlineData(new int[] { 2, 1 }, new int[] { 0, 1 }, 2)]
        [InlineData(new int[] { 1, 2 }, new int[] { 1, 0 }, 1)]
        [InlineData(new int[] { 1, 1 }, new int[] { 0, 0 }, 2)]

        [InlineData(new int[] { 1, 2, 3, 10 }, new int[] { 0,0,0,1 }, 4)]
        [InlineData(new int[] { 1, 2, 3, 10 }, new int[] { 0, 1, 0, 0 }, 3)]
        [InlineData(new int[] { 5, 5, 8 }, new int[] { 1, 1, 0 }, 1)]
        [InlineData(new int[] { 8, 5, 5 }, new int[] { 0, 1, 1 }, 3)]
        [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 0, 1 }, 2)]




        [InlineData(new int[] { }, new int[] {  }, 0)]
        [InlineData(new int[] { 1_000_000_000, 1_000_000_000 }, new int[] { 1, 0 }, 1)]

        public void test(int []A, int[] B, int R)
        {
            Assert.Equal(R, s.solution(A, B));

        }
        
    }
}

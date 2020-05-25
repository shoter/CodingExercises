using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson9c
{
    public class Test
    {
        Codility.Lessons.Lesson9c.Solution s = new Lessons.Lesson9c.Solution();

        [Theory]
        [InlineData(new int[] { 3, 2, -6, 4, 0}, 5)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 0 }, 1)]
        [InlineData(new int[] { 1, -5, 2 }, 2)]
        [InlineData(new int[] { 1, 5, -7, 5, -3, -1, 6  }, 7)]
        [InlineData(new int[] { - 5, -2, -3 }, -2)]


        [InlineData(new int[] { -123, 5 }, 5)]




        public void test(int[] A, int R)
        {
            Assert.Equal(R, s.solution(A));
        }

    }
}

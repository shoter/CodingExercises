using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson16a
{
    public class Test
    {
        Codility.Lessons.Lesson16a.Solution s { get; } = new Lessons.Lesson16a.Solution();

        [Theory]
        [InlineData(new int[] { 1, 3, 7, 9, 9 }, new int[] { 5, 6, 8, 9, 10 }, 3)]
        [InlineData(new int[] { 1}, new int[] { 2}, 1)]
        [InlineData(new int[] { }, new int[] { }, 0)]

        [InlineData(new int[] { 2, 7, 1, 9 }, new int[] { 8, 9, 10, 14 }, 2)]



        public void test(int [] A, int [] B, int R)
        {
            Assert.Equal(R, s.solution(A, B));
        }
    }
}

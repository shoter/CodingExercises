using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson13a
{
    public class Test
    {
        Codility.Lessons.Lesson13a.Solution s { get; } = new Lessons.Lesson13a.Solution();
        [Theory]
        [InlineData(new int[] { 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0}, 3)]
        [InlineData(new int[] { 0, 0, 0 }, -1)]
        [InlineData(new int[] {  }, 1)]
        [InlineData(new int[] { 0 }, 1)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 0, 1 }, 1)]
        [InlineData(new int[] { 1, 0 }, 1)]
        [InlineData(new int[] { 0, 0, 0, 0, 1 }, 2)]



        public void test(int[] A, int R)
        {
            Assert.Equal(R, s.solution(A));
        }
        
    }
}

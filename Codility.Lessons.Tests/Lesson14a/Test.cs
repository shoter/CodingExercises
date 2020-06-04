using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson14a
{
    public class Test
    {
        Codility.Lessons.Lesson14a.Solution s = new Lessons.Lesson14a.Solution();

        [Theory]
        [InlineData(3, 5, new int[] { 2, 1, 5, 1, 2, 2, 2 }, 6)]
        [InlineData(2, 5, new int[] { 1,2,4,7,8,9}, 17)]
        [InlineData(3, 5, new int[] { 1, 2, 4, 7, 8, 9 }, 14)]
        [InlineData(4, 5, new int[] { 1, 2, 4, 7, 8, 9 }, 9)]
        public void test(int K, int M, int[] A, int R)
        {
            Assert.Equal(R, s.solution(K, M, A));
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson5e1
{
    public class Test
    {
        Codility.Lessons.Lesson5e1.Solution s = new Lessons.Lesson5e1.Solution();
        [Theory]
        [InlineData(new int[] { 2, 3, 7, 5, 1, 3, 9}, 4, 6, 25)]
        public void test(int[] A, int K, int M, int R)
        {
            Assert.Equal(R, s.solution(A, K, M));
        }

        [Theory]
        [InlineData(new int[] { 2, 3, 7, 5, 1, 3, 9 }, 4, 6, 25)]
        public void brute(int[] A, int K, int M, int R)
        {
            Assert.Equal(R, s.brute(A, K, M));
        }


    }
}

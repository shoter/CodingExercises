using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson5d
{
    public class Test
    {
        Codility.Lessons.Lesson5d.Solution s = new Lessons.Lesson5d.Solution();

        [Theory]
        [InlineData(new int[] { 0, 1, 0, 1, 1 }, 5)]
        public void test(int[] A, int R)
        {
            Assert.Equal(R, s.solution(A));
        }

        [Theory]
        [InlineData(new int[] { 0, 1, 0, 1, 1 }, 5)]
        public void brute(int[] A, int R)
        {
            Assert.Equal(R, s.brute(A));
        }

        [Fact]
        public void bigChecked()
        {
            int size = 1000;
            int[] A = new int[size];
            Random r = new Random();
            for (int i = 0; i < size; ++i)
                A[i] = r.Next(0, 2);

            Assert.Equal(s.brute(A), s.solution(A));
        }

    }
}

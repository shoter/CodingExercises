using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson8b
{
    public class Test
    {
        Codility.Lessons.Lesson8b.Solution s = new Lessons.Lesson8b.Solution();

        [Theory]
        [InlineData(new int[] { 4, 3, 4, 4, 4, 2 }, 2)]
        [InlineData(new int[] { 1}, 0)]
        [InlineData(new int[] { 1, 1 }, 1)]
        [InlineData(new int[] { 1, 3 }, 0)]
        [InlineData(new int[] { 1, 1, 3 }, 0)]
        public void test(int[] A, int R)
        {
            Assert.Equal(R, s.solution(A));
        }

        [Fact]
        public void bigChecked()
        {
            for(int x = 0; x < 10000; ++x)
            {
                int size = Math.Min(x + 1, 100);
                int[] A = new int[size];
                Random r = new Random();
                for (int i = 0; i < size; ++i)
                    A[i] = r.Next(-100, 100);

                Assert.Equal(s.brute(A), s.solution(A));
            }
        }
        
    }
}

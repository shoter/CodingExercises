using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson6d
{
    public class Test
    {
        Codility.Lessons.Lesson6d.Solution s = new Lessons.Lesson6d.Solution();

        [Theory]
        [InlineData(new int[] { 10, 2, 5, 1, 8, 20 }, 1)]
        [InlineData(new int[] { int.MaxValue, int.MaxValue - 1, int.MaxValue - 2}, 1)]
        [InlineData(new int[] { 10, 50, 5, 1}, 0)]
        [InlineData(new int[] {1}, 0)]
        [InlineData(new int[] { 1, 2 }, 0)]
        [InlineData(new int[] { }, 0)]


        public void test(int[] A ,int R)
        {
            Assert.Equal(R, s.solution(A));

        }

        [Theory]
        [InlineData(new int[] { 10, 2, 5, 1, 8, 20 }, 1)]
        [InlineData(new int[] { 10, 50, 5, 1 }, 0)]

        public void testBrute(int[] A, int R)
        {
            Assert.Equal(R, s.brute(A));
        }


        [Fact]
        public void autoCheck()
        {
            for(int x = 0; x < 1000; ++ x)
            {
                int size = 1000;
                Random rand = new Random();
                int[] A = new int[size];
                for (int i = 0; i < A.Length; ++i)
                    A[i] = rand.Next(-100, 100);

                Assert.Equal(s.brute(A), s.solution(A));
            }
        }



    }
}

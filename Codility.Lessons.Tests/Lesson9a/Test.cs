using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson9a
{
    public class Test
    {
        Codility.Lessons.Lesson9a.Solution s = new Lessons.Lesson9a.Solution();

        [Theory]
        [InlineData(new int[] { 3, 2, 6, -1, 4, 5, -1, 2 }, 17)]
        [InlineData(new int[] { 3, 6, 7 }, 0)]
        [InlineData(new int[] { 3, 6, 7, 8 }, 7)]
        [InlineData(new int[] { 3, 6, 7, 8, 9 }, 15)]
        [InlineData(new int[] { -999, -1, -1, 2, 4, 1, 999 }, 7)]
        [InlineData(new int[] { 999, 5, 7, -50, -20, 5, 15, 2, 999 }, 22)]
        public void test(int[] A, int R)
        {
            Assert.Equal(R, s.solution(A));
        }


        [Theory]
        [InlineData(new int[] { 3, 2, 6, -1, 4, 5, -1, 2 }, 17)]
        [InlineData(new int[] { 3, 6, 7 }, 0)]
        [InlineData(new int[] { 3, 6, 7, 8 }, 7)]
        [InlineData(new int[] { 3, 6, 7, 8, 9 }, 15)]
        [InlineData(new int[] { -999, -1, -1, 2, 4, 1, 999 }, 7)]
        [InlineData(new int[] { 999, 5, 7, -50, -20, 5, 15, 2, 999 }, 22)]
        public void brute(int[] A, int R)   
        {
            Assert.Equal(R, s.brute(A));
        }

        [Fact]
        public void autoCHeck()
        {
            for(int x = 0; x < 1000; ++x)
            {
                int size = 50;
                Random r = new Random();
                int[] A = new int[size];

                for (int i = 0; i < size; ++i)
                    A[i] = r.Next(-10, 10);

                Assert.Equal(s.brute(A), s.solution(A));
            }
        }


    }
}

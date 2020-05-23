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
        [InlineData(new int[] { 2, 3, 4}, 2, 1, 7)]
        [InlineData(new int[] { 2, 3, 4 }, 0, 1,5)]
        [InlineData(new int[] { 2, 3, 4 }, 0, 0, 2)]
        [InlineData(new int[] { 2, 3, 4 }, 0, 2, 9)]
        [InlineData(new int[] { 2, 3, 4 }, 2, 2, 9)]
        [InlineData(new int[] { 6, 1, 3, 2, 9 }, 3, 4, 15)]



        public void test(int[] A, int K, int M, int R)
        {
            Assert.Equal(R, s.solution(A, K, M));
        }

        [Theory]
        [InlineData(new int[] { 2, 3, 7, 5, 1, 3, 9 }, 4, 6, 25)]
        [InlineData(new int[] { 2, 3, 4 }, 2, 1, 7)]
        [InlineData(new int[] { 2, 3, 4 }, 0, 1, 5)]
        [InlineData(new int[] { 2, 3, 4 }, 0, 0, 2)]
        [InlineData(new int[] { 2, 3, 4 }, 0, 2, 9)]
        [InlineData(new int[] { 2, 3, 4 }, 2, 2, 9)]
        [InlineData(new int[] { 6, 1, 3 ,2 ,9}, 3, 4, 15)]
        public void brute(int[] A, int K, int M, int R)
        {
            Assert.Equal(R, s.brute(A, K, M));
        }

        [Fact]
        public void bigCheck()
        {
            for (int x = 0; x < 1000; ++x)
            {
                int size = 5;
                Random r = new Random();
                int K = r.Next(0, size);
                int M = r.Next(0, size);
                int[] A = new int[size];
                for (int i = 0; i < size; ++i)
                    A[i] = r.Next(0, 10);
                Assert.Equal(s.brute(A, K, M), s.solution(A, K, M));
            }
        }


    }
}

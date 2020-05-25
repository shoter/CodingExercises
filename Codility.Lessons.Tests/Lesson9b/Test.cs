using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson9b
{
    public class Test
    {
        Codility.Lessons.Lesson9b.Solution s = new Lessons.Lesson9b.Solution();

        [Theory]
        [InlineData(new int[] { 23171, 21011, 21123, 21366, 21013, 21367}, 356  )]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 123}, 0)]
        [InlineData(new int[] { 5, 2 , 7}, 5)]
        [InlineData(new int[] { 1000, 1001,1 , 3}, 2)]
        [InlineData(new int[] { 1000, 999}, 0)]
        public void test(int[] A, int R)
        {
            Assert.Equal(R, s.solution(A));
        }

        [Theory]
        [InlineData(new int[] { 23171, 21011, 21123, 21366, 21013, 21367 }, 356)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { 123 }, 0)]
        [InlineData(new int[] { 5, 2, 7 }, 5)]
        [InlineData(new int[] { 1000, 1001, 1, 3 }, 2)]
        [InlineData(new int[] { 1000, 999 }, 0)]
        public void bruteTest(int[] A, int R)
        {
            Assert.Equal(R, s.brute(A));
        }


        [Fact]
        public void autoCheck()
        {
            for(int x = 0;x < 1000; ++x)
            {
                int[] A = new int[x];
                Random rand = new Random();
                for (int i = 0; i < x; ++i)
                    A[i] = rand.Next(0, 200_000);

                Assert.Equal(s.brute(A), s.solution(A));
            }
        }


    }
}

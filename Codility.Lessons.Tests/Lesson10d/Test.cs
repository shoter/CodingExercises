using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson10d
{
    public class Test
    {
        Codility.Lessons.Lesson10d.Solution s { get; } = new Lessons.Lesson10d.Solution();

        [Theory]
        [InlineData(new int[] { 1,2,3, 4,3,4, 1,2,3,4, 6, 2 }, 3)]
        [InlineData(new int[] { 1, 8, 0, 0, 9, 9 }, 2)]
        [InlineData(new int[] { 5, 7, 2}, 1)]


        public void test(int[]A , int R)
        {
            Assert.Equal(R, s.solution(A));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }, 3)]
        public void bruteTest(int[] A, int R)
        {
            Assert.Equal(R, s.brute(A));
        }

        [Theory]
        [InlineData(1, new int[] { 1 })]
        [InlineData(2, new int[] { 1,2 })]
        [InlineData(3, new int[] { 1, 3 })]
        [InlineData(4, new int[] { 1,2 , 4 })]
        [InlineData(5, new int[] { 1, 5 })]
        [InlineData(6, new int[] { 1, 2, 3, 6 })]
        [InlineData(7, new int[] { 1, 7 })]
        [InlineData(8, new int[] { 1, 2, 4, 8 })]

        public void divideTest(int N, int[] R)
        {
            int[] x = s.dividers(N).ToArray();
            Assert.Equal(R.Length, x.Length);
            foreach (var r in R)
                x.Single(y => y == r);
        }


        [Fact]
        public void big()
        {
            for (int i = 0; i < 1000; ++i)
            {
                int[] A = new int[100_000 - 100];
                Random r = new Random();
                for (int x = 0; x < A.Length; ++x)
                    A[x] = r.Next(0, 10);

                s.solution(A);
            }
        }

        [Fact]
        public void autoCheck()
        {
            for(int i = 1;i < 100; ++i)
                for(int j = 0;j < 1000; ++j)
            {
                int[] A = new int[i];
                Random r = new Random();
                for (int x = 0; x < i; ++x)
                    A[x] = r.Next(0, 10);

                 Assert.Equal(s.brute(A), s.solution(A));

            }
        }





    }
}

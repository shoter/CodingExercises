using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson11a
{
    public class Test
    {
        Codility.Lessons.Lesson11a.Solution s { get; } = new Lessons.Lesson11a.Solution();

        [Theory]
        [InlineData(new int[] { 3, 1, 2, 3, 6 }, new int[] { 2, 4, 3, 2, 0 })]
        [InlineData(new int[] { 100 }, new int[] { 0 })]
        [InlineData(new int[] { 2, 5 }, new int[] { 1, 1 })]
        [InlineData(new int[] { 3, 6, 9 }, new int[] { 2, 1, 1 })]

        [InlineData(new int[] { 9, 6, 9 }, new int[] { 1, 2, 1 })]

        [InlineData(new int[] { 1, 2, 3, 4, 5}, new int[] { 4, 3, 3, 2, 3 })]


        public void test(int[] A, int[] R)
        {
            Assert.Equal(R, s.solution(A));
        }

        [Theory]
        [InlineData(new int[] { 3, 1, 2, 3, 6 }, new int[] { 2, 4, 3, 2, 0 })]
        [InlineData(new int[] { 100 }, new int[] { 0 })]
        [InlineData(new int[] { 2, 5 }, new int[] { 1, 1 })]
        [InlineData(new int[] { 3, 6, 9 }, new int[] { 2, 1, 1 })]
        public void testB(int[] A, int[] R)
        {
            Assert.Equal(R, s.brute(A));
        }

        [Fact]
        public void autoCheck()
        {
            for (int x = 1; x <= 1000; ++x)
            {
                int[] A = new int[x];
                Random r = new Random();
                for (int i = 0; i < x; ++i)
                    A[i] = r.Next(1, x * 2);

                Assert.Equal(s.brute(A), s.solution(A));
            }
        }


        [Fact]
        public void big()
        {
            for (int j = 0; j < 10; ++j)
            {
                int x = 50_000;
                int[] A = new int[x];
                Random r = new Random();
                for (int i = 0; i < x; ++i)
                    A[i] = r.Next(1, x * 2);

                s.solution(A);
            }
        }

        [Fact]
        public void big2()
        {
            for (int j = 0; j < 1; ++j)
            {
                int x = 50_000;
                int[] A = new int[x];
                Random r = new Random();
                for (int i = 0; i < x - 1; ++i)
                    A[i] = r.Next(1,4);

                A[x - 1] = x * 2;

                s.solution(A);
            }
        }



    }
}

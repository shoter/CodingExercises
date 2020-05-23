using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson6c
{
    public class Test
    {
        Codility.Lessons.Lesson6c.Solution s = new Lessons.Lesson6c.Solution();

        [Theory]
        [InlineData(new int[] { 1, 5, 2, 1, 4, 0 }, 11)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { int.MaxValue, 1 }, 1)]


        public void test(int[] A, int R)
        {
            Assert.Equal(R, s.solution(A));
        }

        [Theory]
        [InlineData(new int[] { 1, 5, 2, 1, 4, 0 }, 11)]
        public void testBrute(int[] A, int R)
        {
            Assert.Equal(R, s.brute(A));
        }


        [Fact]
        public void big()
        {
            int size = 100_000;
            int[] A = new int[size];

            Random r = new Random();
            for (int i = 0; i < size; ++i)
                A[i] = r.Next(0, 1000);

            s.solution(A);
        }

        [Fact]
        public void bigChecked()
        {
            for (int x = 0; x < 100; ++x)
            {
                int size = 100_00;
                int[] A = new int[size];

                Random r = new Random();
                for (int i = 0; i < size; ++i)
                    A[i] = r.Next(100, 1000);

                Assert.Equal(s.brute(A), s.solution(A));
            }
        }


    }
}

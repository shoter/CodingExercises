using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson15a
{
    public class Test
    {
        Codility.Lessons.Lesson15a.Solution s { get; } = new Lessons.Lesson15a.Solution();

        [Theory]
        [InlineData(new int[] { -5, -3, -1, 0, 3, 6}, 5)]
        [InlineData(new int[] { 0 }, 1)]
        [InlineData(new int[] { int.MaxValue }, 1)]
        [InlineData(new int[] { int.MinValue }, 1)]
        [InlineData(new int[] { int.MinValue, int.MaxValue }, 2)]
        [InlineData(new int[] { int.MinValue, 0, int.MaxValue }, 3)]
        [InlineData(new int[] { int.MinValue, int.MinValue, int.MinValue ,0, int.MaxValue }, 3)]
        [InlineData(new int[] { int.MinValue, int.MinValue, -5 ,0, int.MaxValue }, 4)]
        [InlineData(new int[] { int.MinValue, 0, 0, int.MaxValue }, 3)]
        [InlineData(new int[] { int.MinValue, 0, 0, 0 ,int.MaxValue }, 3)]
        public void test(int[] A, int R)
        {
            Assert.Equal(R, s.solution(A));
        }

        [Theory]
        [InlineData(new int[] { -5, -3, -1, 0, 3, 6 }, 5)]
        [InlineData(new int[] { 0 }, 1)]
        [InlineData(new int[] { int.MaxValue }, 1)]
        [InlineData(new int[] { int.MinValue }, 1)]
        [InlineData(new int[] { int.MinValue, int.MaxValue }, 2)]
        [InlineData(new int[] { int.MinValue, 0, int.MaxValue }, 3)]
        [InlineData(new int[] { int.MinValue, int.MinValue, int.MinValue, 0, int.MaxValue }, 3)]
        [InlineData(new int[] { int.MinValue, int.MinValue, -5, 0, int.MaxValue }, 4)]
        [InlineData(new int[] { int.MinValue, 0, 0, int.MaxValue }, 3)]
        [InlineData(new int[] { int.MinValue, 0, 0, 0, int.MaxValue }, 3)]
        public void testBrute(int[] A, int R)
        {
            Assert.Equal(R, s.brute(A));
        }

        [Fact]
        public void big()
        {
            int[] A = new int[100_000];
            Random r = new Random();
            for (int i = 0; i < A.Length; ++i)
                A[i] = -1 * A.Length + 2 * i;

            s.solution(A);
        }

        [Fact]
        public void autoCheck()
        {
            for(int x = 1; x <= 10_00; ++x)
            {
                for (int a = 0; a < 10; ++a)
                {
                    int[] A = new int[x];
                    Random r = new Random();
                    for (int i = 0; i < x; ++i)
                        A[i] = r.Next(-1 * x, x);

                    List<int> temp = A.ToList();

                    temp.Sort();

                    A = temp.ToArray();

                    Assert.Equal(s.brute(A), s.solution(A));
                }
            }
        }

    }
}

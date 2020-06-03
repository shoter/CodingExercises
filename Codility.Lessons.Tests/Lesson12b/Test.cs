using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson12b
{
    public class Test
    {
        Codility.Lessons.Lesson12b.Solution s { get; } = new Lessons.Lesson12b.Solution();

        [Theory]
        [InlineData(new int[] { 1 }, new int[] { 2 }, 0)]
        [InlineData(new int[] { 15, 10, 3 }, new int[] { 75, 30, 5 }, 1)]
        [InlineData(new int[] { 12 }, new int[] { 18 }, 1)]
        [InlineData(new int[] { 50 }, new int[] { 40 }, 1)]
        [InlineData(new int[] { 40 }, new int[] { 50 }, 1)]



        public void test(int[] A, int[] B, int R)
        {
            Assert.Equal(R, s.solution(A, B));
        }

        [Theory]
        [InlineData(new int[] { 15, 10, 3 }, new int[] { 75, 30, 5 }, 75,  1)]

        public void testBrute(int[] A, int[] B, int N,int R)
        {
            Assert.Equal(R, s.brute(A, B, N));
        }

        [Theory]
        [InlineData(new bool[] { false, false, true, true, false, true, false, true, false, false, false, true, false, true }, 13)]
        public void sieveTest(bool[] R, int N)
        {
            bool[] r = s.sieve(N).R;
            Assert.Equal(R, r);
        }

        [Fact]
        public void big()
        {
            int Z = 6_000;
            int[] A = new int[Z];
            int[] B = new int[Z];
            for(int i = 0; i < Z; ++i)
            {
                A[i] = int.MaxValue - 1 * i;
                B[i] = int.MaxValue - 1000 - 1 * i;
            }

            s.solution(A, B);
        }

        [Fact]
        public void auto()
        {
            for(int x = 1; x <= 3; ++x)
            {
                for(int N = 2; N <= 100; ++N)
                {
                    for(int j = 0; j < 5; ++j)
                    {
                        Random r = new Random();
                        int[] A = new int[x];
                        int[] B = new int[x];

                        for(int i = 0;i < x; ++i)
                        {
                            A[i] = r.Next(1, N);
                            B[i] = r.Next(1, N);
                        }
                        Assert.Equal(s.brute(A, B, N), s.solution(A, B));

                    }

                }
            }
        }

    


    }
}

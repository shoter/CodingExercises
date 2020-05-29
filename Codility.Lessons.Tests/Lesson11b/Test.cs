using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson11b
{
    public class Test
    {
        Codility.Lessons.Lesson11b.Solution s { get; } = new Lessons.Lesson11b.Solution();

        [Theory]
        [InlineData(26, new int[] { 1, 4, 16 }, new int[] { 26, 10, 20 }, new int[] { 10, 4, 0 })]
        public void test(int N, int[] P, int[] Q,int[] R)
        {
            Assert.Equal(R, s.solution(N, P, Q));
        }

        [Theory]
        [InlineData(26, new int[] { 1, 4, 16 }, new int[] { 26, 10, 20 }, new int[] { 10, 4, 0 })]
        public void bruteTest(int N, int[] P, int[] Q, int[] R)
        {
            Assert.Equal(R, s.brute(N, P, Q));
        }

        [Fact]
        public void autoCheck()
        {
            for(int x = 1; x <= 100; ++ x)
            {
                int[] P = new int[x];
                int[] Q = new int[x];
                Random r = new Random();

                int n = r.Next(10, 1000);

                for(int i = 0;i < x; ++i)
                {
                    P[i] = r.Next(1, n);
                    Q[i] = r.Next(n, n + n);
                }

                Assert.Equal(s.brute(n * 2, P, Q), s.solution(n * 2, P, Q));
            }

        }

        [Theory]
        [InlineData(8, new bool[] { false, false, true, true, false, true, false, true, false})]
        public void sieveTest(int N, bool[] R)
        {
            Assert.Equal(R, s.sieve(N));
        }

        [Fact]
        public void factorTest()
        {
            int[] R = s.factors(100);
            for(int i = 2; i <= 100; ++i)
            {
                for(int x = 2; x <= i; ++i)
                {
                    if(i % x == 0)
                    {
                        Assert.Equal(x, R[i]);
                        break;
                    }
                }
            }
        }

        [Theory]
        [InlineData(true, new int[] { 4, 6, 9, 10, 14, 15, 21, 22, 25, 26 })]
        [InlineData(false, new int[] { 1,2, 5, 7, 8, 11, 12, 13, 16, 17, 18, 19, 20, 23, 24, 27})]
        public void IsPrimeTest(bool isPrime, int[] numbers)
        {
            s.sieve(1000);
            s.factors(1000);
            foreach (var n in numbers)
                Assert.Equal(isPrime, s.IsPrime(n));
        }

        [Fact]
        public void big()
        {
            int size = 30_000;
            int[] P = new int[size];
            int[] Q = new int[size];
            for(int i = 0;i < size;++i)
            {
                P[i] = 1;
                Q[i] = 50_000 - i;
            }

            s.solution(50_000, P, Q);
        }

    }
}

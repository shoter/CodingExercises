using System;
using Xunit;

namespace Misc.Tests
{
    public class BinarySearchTests
    {
        [Theory]
        [InlineData(new bool[] { true }, 0)]
        [InlineData(new bool[] { true, false }, 0)]
        [InlineData(new bool[] { true, true ,false }, 1)]
        [InlineData(new bool[] { true, false, false }, 0)]
        [InlineData(new bool[] { true, true, true }, 2)]



        public void Test1(bool[] A, int R)
        {
            Assert.Equal(R, new BinarySearch().FindDiverge(A));
        }

        [Fact]
        public void test()
        {
            for(int x = 0; x < 1000; ++x)
            {
                bool[] A = new bool[x + 1];
                Random r = new Random();
                int start = r.Next(1, x + 1);
                for (int i = 0; i < start; ++i)
                    A[i] = true;

                /*int answer = A.Length - 1;
                for(int i = A.Length - 1; i >= 1; --i)
                {
                    if(A[x] != A[x - 1])
                    {
                        answer = x - 1;
                        break;
                    }
                }*/

                Assert.Equal(start - 1, new BinarySearch().FindDiverge(A));
            }
        }
    }
}

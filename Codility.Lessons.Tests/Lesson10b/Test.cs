using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson10b
{
    public class Test
    {

        Codility.Lessons.Lesson10b.Solution s { get; } = new Lessons.Lesson10b.Solution();

        [Theory]
        [InlineData(new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }, 3)]
        [InlineData(new int[] { 8, 4, 5, 2, 5, 8, 3, 9, 5 }, 2)]
        [InlineData(new int[] { 3, 9, 9, 3, 2, 7, 8, 3, 6, 5, 2, 8, 5, 7 }, 2)]
        [InlineData(new int[] { 8, 5, 2, 7, 4, 1, 6, 1, 1, 4, 7, 9, 8, 4, 3, 9, 3, 4, 7, 5, 8, 8, 6, 1, 1, 7, 1, 9, 5, 7, 7, 6, 7, 8, 8, 2, 4, 6, 4, 8, 5, 3, 7, 6, 8, 5, 4, 3, 6, 6, 3, 6, 4, 7, 3, 1, 8 }, 7)]
        public void test(int[] N, int R)
        {
            Assert.Equal(s.solution(N), R);
        }

        [Theory]
        [InlineData(new int[] { 1, 5, 3, 4, 3, 4, 1, 2, 3, 4, 6, 2 }, 3)]
        public void bruteTest(int[] N, int R)
        {
            Assert.Equal(R, s.brute(N));
        }

        [Fact]
        public void big()
        {
            List<int> arr = new List<int>();
            for(int i = 0; i < 133333; ++i)
            {
                arr.Add(1);
                arr.Add(2);
                arr.Add(1);
            }

            s.solution(arr.ToArray());
        }

        [Fact]
        public void autoCheck()
        {
            for(int x = 3; x < 1000; ++ x)
            {
                int[] A = new int[x];
                Random r = new Random();
                for(int i = 0;i < A.Length; ++i)
                {
                    A[i] = r.Next(1, 10);
                }

                string exp = $"new int[] {{{string.Join(',', A)}}}, {s.brute(A)}";
                Assert.Equal(s.brute(A), s.solution(A));
            }
        }


    }
}

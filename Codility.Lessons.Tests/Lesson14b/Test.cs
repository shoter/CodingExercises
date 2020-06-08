using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson14b
{
    public class Test
    {
        Codility.Lessons.Lesson14b.Solution s { get; } = new Lessons.Lesson14b.Solution();

        [Theory]
        [InlineData(new int[] { 1, 4, 5, 8}, new int[] { 4, 5, 9, 10}, new int[] { 4, 6, 7, 10, 2 }, 4)]
        [InlineData(new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 2, 1, 3 }, 1)]
        [InlineData(new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 1, 3, 2 }, 2)]
        [InlineData(new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 1, 1 }, -1)]
        [InlineData(new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 3 }, -1)]
        public void test(int[] A, int[] B, int [] C, int R)
        {
            Assert.Equal(R, s.solution(A, B, C));
        }

        [Fact]
        public void big()
        {
            int size = 30_000;
            int[] A = new int[size];
            int[] B = new int[size];
            int[] C = new int[size];

            Random r = new Random();
            for(int i = 0;i < size; ++i)
            {
                A[i] = r.Next(1, 1000);
                B[i] = r.Next(1000, 2000);
                C[i] = r.Next(1, 2000);
            }

            s.solution(A, B, C);
        }
        
    }
}

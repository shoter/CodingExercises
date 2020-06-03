using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson13b
{
    public class Test
    {
        Codility.Lessons.Lesson13b.Solution s = new Lessons.Lesson13b.Solution();
        [Theory]
        [InlineData(new int[] { 4, 4, 5, 5, 1 }, new int[] { 3, 2, 4, 3, 1 }, new int[] { 5, 1, 8, 0, 1 })]
        public void test(int[] A, int [] B, int[] R)
        {
            Assert.Equal(R, s.solution(A, B));

        }

        [Fact]
        public void big()
        {
            int[] A = new int[50_000];
            int[] B = new int[50_000];

            for(int i = 0;i < 50_000; ++i)
            {
                A[i] = 50_000 - i;
                B[i] = 30;
            }

            int[] R = s.solution(A, B);

            foreach (var r in R)
                Assert.True(r > 0);
        }
        
    }
}

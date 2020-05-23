using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson6b
{
    public class Test
    {
        Codility.Lessons.Lesson6b.Solution s = new Lessons.Lesson6b.Solution();

        [Theory]
        [InlineData(new int[] { -3, 1, 2, -2, 5, 6 }, 60)]
        [InlineData(new int[] { -3, 1, 5, -2, -10, -6 }, 300)]
        [InlineData(new int[] { -3, -2, 1 }, 6)]
        [InlineData(new int[] { -3, -2, 2, 1, 1 }, 12)]
        [InlineData(new int[] { 1, 2, -3, 1, -2}, 12)]





        public void test(int[] A, int R)
        {
            Assert.Equal(R, s.solution(A));
        }
        [Fact]
        public void big()
        {
            int size = 100_000;
            int[] A = new int[size];
            Random r = new Random();
            for(int i = 0;i < size;++i)
            {
                A[i] = r.Next(-100, 100);
            }

            s.solution(A);

        }
        
    }
}

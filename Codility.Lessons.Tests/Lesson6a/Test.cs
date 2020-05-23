using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson6a
{
    public class Test
    {
        Codility.Lessons.Lesson6a.Solution s = new Lessons.Lesson6a.Solution();
        [Theory]
        [InlineData(new int[] { 2, 1, 1, 2, 3, 1 }, 3)]
        [InlineData(new int[] {  }, 0)]

        public void test(int[] A, int R)
        {
            Assert.Equal(R, s.solution(A));
        }

        [Fact]
        public void bigChecked()
        {
            Random r = new Random();
            List<int> numbers = new List<int>();
            for(int i = 0; i < 100_000; ++i)
            {
                do
                {
                    numbers.Add(i);
                } while (r.Next(0, 2) == 0);
            }

            int[] A = new int[numbers.Count];

            for(int i = 0;i < A.Length; ++i)
            {
                int index = r.Next(0, numbers.Count);
                A[i] = numbers[index];
                numbers.RemoveAt(index);
            }

            Assert.Equal(100_000, s.solution(A));
        }
    }
}

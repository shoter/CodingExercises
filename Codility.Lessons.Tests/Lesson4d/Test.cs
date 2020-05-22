using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson4d
{
    public class Test
    {
        Codility.Lessons.Lesson4d.Solution s = new Lessons.Lesson4d.Solution();

        [Theory]
        [InlineData(new int[] { 4, 1, 3, 2 }, 1)]
        [InlineData(new int[] { 4, 1, 2, 2 }, 0)]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 2 }, 0)]
        [InlineData(new int[] { 2, 3, 4 ,6 }, 0)]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 6 }, 0)]


        public void test(int[] A, int R)
        {   
            Assert.Equal(R, s.solution(A));

        }

        [Fact]
        public void bigYes()
        {
            Random r = new Random();
            int[] A = new int[100_000];
            List<int> numbers = new List<int>();
            for (int i = 0; i < A.Length; ++i)
                numbers.Add(i + 1);
            for(int i = 0;i < A.Length; ++i)
            {
                int x = r.Next(0, numbers.Count);
                A[i] = numbers[x];
                numbers.RemoveAt(x);
            }

            Assert.Equal(1, s.solution(A));
        }

        [Fact]
        public void bigNo()
        {
            Random r = new Random();
            int[] A = new int[100_000];
            List<int> numbers = new List<int>();
            for (int i = 0; i < A.Length; ++i)
                numbers.Add(i + 2);
            for (int i = 0; i < A.Length; ++i)
            {
                int x = r.Next(0, numbers.Count);
                A[i] = numbers[x];
                numbers.RemoveAt(x);
            }

            Assert.Equal(0, s.solution(A));
        }

    }
}

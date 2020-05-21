using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codility.Lessons.Lesson3b;
using Xunit;

namespace Codility.Lessons.Tests.Lesson3b
{
    public class Test
    {
        Solution s { get; } = new Solution();

        [Theory]
        [InlineData(4, new int[] { 2, 3, 1, 5 })]
        [InlineData(2, new int[] { 1 })]
        [InlineData(1, new int[] { 2 })]
        [InlineData(5, new int[] { 2, 3, 1, 4 })]
        [InlineData(1, new int[] { 2, 3, 5, 4 })]

        public void test(int r, int[] A)
        {
            Assert.Equal(r, s.solution(A));
        }


        [Fact]
        public void big_test()
        {
            for (int o = 0; o < 100; ++o)
            {
                Random rand = new Random();
                var input = new List<int>();
                var numbers = new List<int>();

                for (int i = 1; i <= 100_000; ++i)
                    numbers.Add(i);

                while (numbers.Count > 1)
                {
                    int r = rand.Next(0, numbers.Count);
                    int n = numbers[r];
                    numbers.RemoveAt(r);
                    input.Add(n);
                }

                Assert.Equal(numbers.First(), s.solution(input.ToArray()));
            }
        }

        
    }
}

using Codility.Lessons.Lesson2b;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson2b
{
    public class Test
    {
        Solution s { get; } = new Solution();

        [Theory]
        [InlineData(5, 1, 3, 5, 3, 1)]
        [InlineData(1, 1)]
        [InlineData(1_000_000_000, 1_000_000_000)]
        [InlineData(1, 1, 1, 1)]
        [InlineData(1, 2, 2, 1)]
        [InlineData(2, 1, 2, 1)]
        [InlineData(1, 1, 2, 2)]
        [InlineData(2, 1, 2, 2, 1, 2)]
        [InlineData(2, 1, 2, 2, 1, 2, 1, 1, 2, 2)]


        [InlineData(1, 2, 2, 1, 3, 3)]

        public void test(int correct, params int[] array)
        {
            var r = s.solution(array);
            Assert.Equal(correct, r);
        }

        [Theory]
        [InlineData(new int[] { 3, 1, 2 }, new int[] { 1, 2, 3 })]
        [InlineData(new int[] { 7, 4, 5, 8, 1, 2, 6, 9, 3 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new int[] { 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9 })]

        public void mergeTest(int[] I, int[] C)
        {
            s.quickSort(I, 0, I.Length);

            Assert.Equal(C, I);
        }

        [Fact]
        public void mergeBig()
        {
            Random r = new Random();
            const int size = 1_000_000;
            int[] arr = new int[size];
            for (int i = 0; i < size; ++i)
            {
                arr[i] = r.Next(0, 1_000_000);
            }
            s.solution(arr);
        }

    }
}

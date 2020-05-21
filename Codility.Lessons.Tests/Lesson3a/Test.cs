using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codility.Lessons.Lesson3a;
using Xunit;

namespace Codility.Lessons.Tests.Lesson3a
{
    public class Test
    {
        Solution s = new Solution();

        [Theory]
        [InlineData(10, 85, 30, 3)]
        [InlineData(10, 20, 10, 1)]
        [InlineData(10, 21, 10, 2)]
        [InlineData(10, 19, 10, 1)]
        [InlineData(10, 100, 10, 9)]
        [InlineData(1, 1_000_000_000, 1, 999_999_999)]
        [InlineData(1,1,1,0)]
        [InlineData(1,2,1,1)]
        public void test(int X, int Y, int D, int R)
        {
            Assert.Equal(R, s.solution(X, Y, D));
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson7d
{
    public class Test
    {
        Codility.Lessons.Lesson7d.Solution s = new Lessons.Lesson7d.Solution();
        [Theory]
        [InlineData(new int[] { 8, 8, 5, 7, 9, 8, 7, 4, 8}, 7)]
        [InlineData(new int[] { 1234 }, 1)]
        [InlineData(new int[] { 1,2,1 }, 2)]
        [InlineData(new int[] { 1, 2, 3, 2, 3, 2, 1 }, 4)]
        [InlineData(new int[] { 1, 2, 3, 2, 3, 2, 1, 2, 2, 2, 3, 4, 4, 4, 3, 2 ,1 }, 7)]
        public void test(int[] H, int R)
        {
            Assert.Equal(R, s.solution(H));
        }
        
    }
}

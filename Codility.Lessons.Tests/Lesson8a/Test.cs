using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson8a
{
    public class Test
    {
        Codility.Lessons.Lesson8a.Solution s = new Lessons.Lesson8a.Solution();
        
        [Theory]
        [InlineData(new int[] { 3, 4, 3, 2, 3, -1, 3, 3 }, 3)]
        public void test(int[] A, int R)
        {
            Assert.Equal(R, A[s.solution(A)]);
        }
        
    }
}

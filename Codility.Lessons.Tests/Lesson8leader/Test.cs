using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson8leader
{
    public class Test
    {
        Codility.Lessons.Lesson8leader.Solution s = new Lessons.Lesson8leader.Solution();
        [Theory]
        [InlineData(new int[] { 1 }, 1)]
        [InlineData(new int[] { 1, 2 }, -1)]
        [InlineData(new int[] { 1, 2, 1 }, 1)]
        [InlineData(new int[] { 1, 1, 2 }, 1)]
        [InlineData(new int[] { 2, 1, 1 }, 1)]
        [InlineData(new int[] { 1, 1, 2 , 3, 1 }, 1)]
        public void test(int[] N, int R)
        {
            Assert.Equal(R, s.leader(N));
        }






    }
}

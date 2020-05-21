using Codility.Lessons.Lesson2a;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson2A
{
    public class Test
    {
        Solution s = new Solution();

        [Fact]
        public void test()
        {
            int[] A = new int[] { 0 };
            int K = 100;
            int[] R = new int[] { 0 };
            int[] M = s.solution(A, K);

            for(int i = 0; i < A.Length; ++i)
            {
                Assert.Equal(R[0], M[0]);
            }
        }

        [Fact]
        public void test2()
        {
            int[] A = new int[] { 0, 1,2,3,4,5 };
            int K = 2;
            int[] R = new int[] { 4, 5, 0, 1, 2, 3 };
            int[] M = s.solution(A, K);

            for (int i = 0; i < A.Length; ++i)
            {
                Assert.Equal(R[0], M[0]);
            }
        }

        [Fact]
        public void test3()
        {
            int[] A = new int[] { };
            int K = 2;
            int[] R = new int[] { };
            int[] M = s.solution(A, K);

            for (int i = 0; i < A.Length; ++i)
            {
                Assert.Equal(R[0], M[0]);
            }
        }

        [Fact]
        public void test4()
        {
            int[] A = new int[] { 0, 1 };
            int K = 1;
            int[] R = new int[] { 1, 0 };
            int[] M = s.solution(A, K);

            for (int i = 0; i < A.Length; ++i)
            {
                Assert.Equal(R[0], M[0]);
            }
        }

        [Fact]
        public void test5()
        {
            int[] A = new int[] { 0, 1, 2, 3, 4, 5 };
            int K = 3;
            int[] R = new int[] { 3, 4, 5, 0, 1, 2 };
            int[] M = s.solution(A, K);

            for (int i = 0; i < A.Length; ++i)
            {
                Assert.Equal(R[0], M[0]);
            }
        }





    }
}

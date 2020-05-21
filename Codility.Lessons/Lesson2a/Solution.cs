using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson2a
{
    public class Solution
    {
        public int[] solution(int[] A, int K)
        {
            if (A.Length == 0)
                return A;

            int[] B = new int[A.Length];
            K %= A.Length;

            for(int i = 0;i < A.Length; ++i)
            {
                int npos = (i + K) % A.Length;
                B[npos] = A[i];
            }

            return B;
        }
    }
}

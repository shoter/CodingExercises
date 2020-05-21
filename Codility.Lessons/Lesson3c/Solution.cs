using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson3c
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int lsum = A[0];
            int rsum = A[1];

            for(int i = 2;i < A.Length; ++ i)
            {
                rsum += A[i];
            }

            int min = Math.Abs(lsum - rsum);

            for(int i = 1; i < A.Length - 1; ++i)
            {
                lsum += A[i];
                rsum -= A[i];
                int diff = Math.Abs(lsum - rsum);

                if (diff < min)
                    min = diff;
            }

            return min;

        }
    }
}

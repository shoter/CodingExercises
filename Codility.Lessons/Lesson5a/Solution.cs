using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson5a
{
    public class Solution
    {
        public int solution(int A, int B, int K)
        {
            int r = 0;

            int a0 = 0;
            if (A % K == 0)
                a0 = A;
            else
                a0 = ((A / K) + 1) * K;

            if (a0 > B)
                return 0;

            int howManyFits = (B - a0) / K;

            return howManyFits + 1;
        }
        
    }
}

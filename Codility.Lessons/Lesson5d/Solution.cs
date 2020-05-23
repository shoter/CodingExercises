using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson5d
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int easters = 0;
            int r = 0;
            for(int i = 0;i < A.Length; ++i)
            {
                if (A[i] == 0)
                    easters++;
                if (A[i] == 1)
                    r += easters;
                if (r > 1_000_000_000)
                    return -1;
            }
            return r;
        }

        public int brute(int[] A)
        {
            int pairs = 0;
            for(int i = 0;i < A.Length - 1; ++i)
            {
                if (A[i] == 1)
                    continue;
                for(int x = i + 1; x < A.Length; ++x)
                {
                    if (A[x] == 1)
                        pairs++;
                }
            }

            if (pairs > 1_000_000_000)
                return -1;

            return pairs;
        }
    }
}

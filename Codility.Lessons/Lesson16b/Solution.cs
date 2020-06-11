using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson16b
{
    public class Solution
    {
        public int solution(int K, int[] A)
        {
            int n = 0;
            int count = 0;
            for(int i =0;i < A.Length; ++i)
            {
                n += A[i];
                if(n >= K)
                {
                    count++;
                    n = 0;
                }
            }

            return count;

        }
    }
}

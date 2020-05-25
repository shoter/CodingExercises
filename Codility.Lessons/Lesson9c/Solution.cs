using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson9c
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int current = 0;
            int max = int.MinValue;
            for(int i = 0;i < A.Length; ++i)
            {
                current = Math.Max(A[i], current + A[i]);
                max = Math.Max(current, max);
            }

            return max;
        }
        
    }
}

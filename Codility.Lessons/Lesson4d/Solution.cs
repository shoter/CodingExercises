using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson4d
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int xor = 0;

            for (int i = 0; i < A.Length; ++i)
            {
                if (A[i] > A.Length + 1)
                    return 0;
                xor ^= A[i] ^ (i + 1);
            }

            return xor == 0 ? 1 : 0;
        }
        
    }
}

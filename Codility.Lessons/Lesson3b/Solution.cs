using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson3b
{
    public class Solution
    {
        public int solution(int[] A)
        {
            bool[] arr = new bool[A.Length + 1];

            for (int i = 0; i < A.Length; ++i)
                arr[A[i] - 1] = true;

            for(int i = 0; i < A.Length + 1; ++i)
            {
                if (!arr[i])
                    return i + 1;
            }

            return -1; // should not happen.
        }
        
    }
}

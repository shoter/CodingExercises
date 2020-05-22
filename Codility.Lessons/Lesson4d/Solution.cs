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
            bool[] arr = new bool[A.Length];

            for (int i = 0; i < A.Length; ++i)
            {
                if (A[i] > A.Length)
                    return 0;

                int index = A[i] - 1;
                if (arr[index])
                    return 0;
                arr[index] = true;
            }

            return 1;

        }
        
    }
}

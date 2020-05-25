using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson9b
{
    public class Solution
    {
       public int solution(int[] A)
        {
            if (A.Length == 0)
                return 0;

            int min = int.MaxValue;
            int max = int.MinValue;

            int maxValue = 0;

            for(int i = 0; i < A.Length; ++i)
            {
                if(A[i] < min)
                {
                    min = A[i];
                    max = A[i];
                }
                else if(A[i] > max)
                {
                    max = A[i];
                }

                if ((max - min) > maxValue)
                    maxValue = max - min;
            }

            return maxValue;
        }

        public int brute(int[] A)
        {
            int maxValue = 0;

            for(int i = 0;i < A.Length; ++i)
            {
                for(int j = i; j < A.Length; ++ j)
                {
                    if (A[j] - A[i] > maxValue)
                        maxValue = A[j] - A[i];
                }
            }

            return maxValue;
        }
    }
}

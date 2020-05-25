using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson9a
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int maxValue = 0;

            int[] maxLeftSlices = new int[A.Length];
            int[] maxRightSlices = new int[A.Length];

            int current = 0;
            for(int i = 1; i < A.Length -1; ++i)
            {
                maxLeftSlices[i] = current = Math.Max(Math.Max(current + A[i], A[i]), 0);
            }

            current = 0;
            for (int i = A.Length - 2; i >= 1; --i)
            {
                maxRightSlices[i] = current = Math.Max(Math.Max(current + A[i], A[i]), 0);
            }

            for(int p = 1; p <= A.Length -2; ++p)
            {
                maxValue = Math.Max(maxValue, maxLeftSlices[p - 1] + maxRightSlices[p + 1]);
            }

            return maxValue;
                    }

        public int brute(int[] A)
        {
            int maxSum = 0;
            for(int x = 0; x < A.Length - 1; ++ x)
            {
                for(int y = x + 1; y < A.Length; ++ y)
                {
                    for(int z = x + 1; z < y; ++z)
                    {
                        int sum = 0;
                        for(int i = x + 1; i < y; ++i)
                        {
                            if (z == i)
                                continue;
                            sum += A[i];
                        }

                        if (sum > maxSum)
                            maxSum = sum;

                    }

                }
            }

            return maxSum;
        }
        
    }
}

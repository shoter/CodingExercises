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
                maxLeftSlices[i] = current = Math.Max(current + A[i], A[i]);
            }

            current = 0;
            for (int i = A.Length - 2; i >= 1; --i)
            {
                maxRightSlices[i] = current = Math.Max(current + A[i], A[i]);
            }

            for(int p = 2; p <= A.Length -3; ++p)
            {
                maxValue = Math.Max(maxValue, maxLeftSlices[p - 1] + maxRightSlices[p + 1]);
            }

            return maxValue;
                    }

        public int brute(int[] A)
        {
            int maxSum = 0;
            for(int x = 1; x < A.Length - 2; ++ x)
            {
                for(int y = x + 1; y < A.Length -1; ++ y)
                {
                    for(int z = x + 1; z < y; ++z)
                    {
                        int sum = 0;
                        for(int i = x; i <= y; ++i)
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

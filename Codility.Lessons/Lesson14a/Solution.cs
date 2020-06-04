using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson14a
{
    public class Solution
    {
        public int solution(int K, int M, int[] A)
        {
            if (A.Length == 1)
                return A[0];

            int maxSum = 0;
            int minSum = int.MaxValue;

            for (int i = 0; i < A.Length; ++i)
            {
                maxSum += A[i];
                minSum = Math.Min(minSum, A[i]);
            }

            while (maxSum != minSum)
            {
                int midSum = (maxSum + minSum) / 2;

                bool ok = isDividable(K, midSum, A);

                if(ok)
                {
                    maxSum = midSum;
                }
                else
                {
                    minSum = midSum + 1;
                }
            }
            return maxSumCalc(K, maxSum, A);
        }

        public bool isDividable(int K, int mid, int[] A)
        {
            int blocksLeft = K;
            int curSum = 0;
            for (int i = 0; i < A.Length; ++i)
            {
                curSum += A[i];

                if (curSum > mid)
                {
                    blocksLeft--;
                    curSum = A[i];
                }

                if (blocksLeft == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public int maxSumCalc(int K, int mid, int[] A)
        {
            int blocksLeft = K;
            int curSum = 0;
            int maxSum = 0;
            for (int i = 0; i < A.Length; ++i)
            {
                maxSum = Math.Max(curSum, maxSum);
                curSum += A[i];

                if (curSum > mid)
                {
                    blocksLeft--;
                    curSum = A[i];
                }

                if (blocksLeft == 0)
                {
                    throw new Exception("WUT?");
                }
            }

            return Math.Max(maxSum, curSum);
        }


    }
}

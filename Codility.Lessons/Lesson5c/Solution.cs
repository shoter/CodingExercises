using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson5c
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int min_sum_2 = int.MaxValue;
            int min_sum_3 = int.MaxValue;

            int i_2 = 0;
            int i_3 = 0;

            for (int i = 0; i < A.Length - 2; ++i)
            {
                if (A[i] + A[i + 1] < min_sum_2)
                {
                    min_sum_2 = A[i] + A[i + 1];
                    i_2 = i;
                }

                if (A[i] + A[i + 1] + A[i + 2] < min_sum_3)
                {
                    min_sum_3 = A[i] + A[i + 1] + A[i + 2];
                    i_3 = i;
                }
            }

            if (A[A.Length - 1] + A[A.Length - 2] < min_sum_2)
            {
                min_sum_2 = A[A.Length - 1] + A[A.Length - 2];
                i_2 = A.Length - 2;
            }

            if(3 * min_sum_2 < 2 * min_sum_3)
            {
                return i_2;
            }
            else if(3 * min_sum_2 >2 * min_sum_3)
            {
                return i_3;
            }
            return Math.Min(i_2, i_3);
        }

        public int brute(int[] A)
        {
            double min = double.MaxValue;
            int minpos = -1;
            for(int x = 0; x< A.Length -1; ++ x)
            {
                double sum = A[x];
                int n = 1;
                for(int y= x + 1; y < A.Length; ++y)
                {
                    ++n;
                    sum += A[y];

                    Debug.WriteLine($"[{x}, {y}] avg - {sum / n}");

                    if ((sum / n) <= min)
                    {
                        min = (sum / n);
                        minpos = x;
                    }
                }

            }

            return minpos;

        }
        
    }
}

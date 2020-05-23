using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson5e1
{
    public class Solution
    {
        public int solution(int[] A, int k, int m)
        {
            int maxS = A.Sum();
            int[] prefix = new int[A.Length + 1];

            int sum = maxS;

            for (int i = 1; i < A.Length; ++i)
            {
                prefix[i] = sum;
                sum -= A[i - 1];
            }

            int max = 0;

            for (int left = 0; left <= m; ++left)
            {
                if (k - left < 0)
                    break;
                int right = m - left * 2;

                if (k + right >= A.Length)
                    continue;

                int grabbed = prefix[k + right + 1] - prefix[k - left];

                if (grabbed > max)
                    max = grabbed;
            }

            return max;
        }

        public int brute(int[] A, int k, int m)
        {
            int max = 0;
            // to the left
            for (int i = 0; i <= m; ++i)
            {
                // to the right
                for (int j = 0; j <= m - i * 2; ++j)
                {
                    int grabbed = 0;
                    for (int x = Math.Max(0, k - i); x <= Math.Min(k + j, A.Length - 1); ++x)
                    {
                        grabbed += A[x];
                    }
                    if (grabbed > max)
                        max = grabbed;
                }

            }
            return max;
        }

    }
}

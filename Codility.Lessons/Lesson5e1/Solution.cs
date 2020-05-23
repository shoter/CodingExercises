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
            int[] prefix = new int[A.Length + 1];

            int sum = 0;

            for (int i = 0; i < A.Length; ++i)
            {
                sum += A[i];
                prefix[i + 1] = sum;
            }

            int max = 0;

            for (int left = 0; left <= m; ++left)
            {
                if (k - left < 0)
                    break;
                int right = Math.Max(m - left * 2, 0);

                if (k + right >= A.Length)
                    continue;

                int grabbed = prefix[k + right + 1] - prefix[k - left];

                if (grabbed > max)
                    max = grabbed;
            }

            for (int right = 0; right <= m; ++right)
            {
                if (k + right >= A.Length)
                    break ;

                int left = Math.Max(m - right * 2, 0);

                if (k - left < 0)
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
                int j = Math.Max(m - i * 2, 0);
                int grabbed = 0;
                for (int x = Math.Max(0, k - i); x <= Math.Min(k + j, A.Length - 1); ++x)
                {
                    grabbed += A[x];
                }
                if (grabbed > max)
                    max = grabbed;
            }

            // to the right
            for (int i = 0; i <= m; ++i)
            {
                int j = Math.Max(m - i * 2, 0);
                int grabbed = 0;
                for (int x = Math.Max(0, k - j); x <= Math.Min(k + i, A.Length - 1); ++x)
                {
                    grabbed += A[x];
                }
                if (grabbed > max)
                    max = grabbed;

            }
            return max;
        }

    }
}

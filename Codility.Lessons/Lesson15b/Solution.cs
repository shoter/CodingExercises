using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson15b
{
    public class Solution
    {
        const int max = 1000000000;
        public int solution(int M, int [] A)
        {
            int left = 0;
            int right = 0;

            Dictionary<int, bool> used = new Dictionary<int, bool>();

            for (int i = 0; i <= M; ++i)
                used.Add(i, false);

            used[A[0]] = true;
            int count = 0;

            while(left < A.Length)
            {
                if (count > max)
                    return max;
                if (right == A.Length - 1)
                {
                    count += right - left + 1;
                    left++;
                    continue;
                }

                int candidate = A[right + 1];
                
                if(!used[candidate])
                {
                    used[candidate] = true;
                    right++;
                }
                else
                {
                    count += right - left + 1;
                    used[A[left]] = false;
                    left++;
                }
            }

            return Math.Min(count, max);
        }
        
    }
}

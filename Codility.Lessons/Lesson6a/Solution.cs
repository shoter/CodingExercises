using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson6a
{
    public class Solution
    {
        public int solution(int[] A)
        {
            HashSet<int> set = new HashSet<int>();
            int numbers = 0;
            for(int i = 0;i < A.Length;++i)
            {
                if (set.Add(A[i]))
                    numbers++;
            }

            return numbers;

        }
        
    }
}

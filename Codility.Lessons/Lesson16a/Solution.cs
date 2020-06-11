using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson16a
{
    public class Solution
    {
        public int solution(int[] A, int [] B)
        {
            if (A.Length == 0)
                return 0;

            int count = 0;
            int current = 0;

            for(int i = 1;i < A.Length; ++i)
            {
                int a2 = A[i];
                int b = B[current];
                int a = A[current];
                int b2 = B[i];

                // no colission - the last ount will increase count of segments.
                if(a2 > b)
                {
                    count++;
                    current = i;
                }
                else
                {
                    //collision - let's take one that end earlier.
                    if(b2 < b)
                    {
                        current = i;
                        // we dropped the initial one in this loop.

                    }
                }
            }

            //we have something that ended here so we increase count by 1
            return count + 1;
        }
    }
}

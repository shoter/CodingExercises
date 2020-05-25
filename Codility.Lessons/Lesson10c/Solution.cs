using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson10c
{
    public class Solution
    {
        public int solution(int N)
        {

            int j = 1;
            int min = int.MaxValue;

            while(j * j <= N)
            {
                if(N % j == 0)
                {
                    int i = N / j;
                    min = Math.Min(min, 2 * (i + j));
                }

                ++j;
            }

            return min;
        }

        public int brute(int N)
        {
            int min = int.MaxValue;
            for(int i = 1;i <= N; ++i)
                for(int j = 1; j <= N; ++j)
                {
                    if(i*j == N)
                    {
                        int per = 2 * (i + j);
                        if (per < min)
                            min = per;
                    }
                }

            return min;
        }
        
    }
}

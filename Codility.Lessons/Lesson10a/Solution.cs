using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson10a
{
    public class Solution
    {
        public int solution(int N)
        {
            long n = N;
            int divs = 0;
            long i = 1;
            while(i * i < N)
            {
                if (N % i == 0)
                    divs += 2;

                ++i;
            }

            if (i * i == N)
                divs += 1;

            return divs;

        }

        public int brute(int N)
        {
            int dividers = 0;

            for(int i = 1;i <= N; ++i)
            {
                for(int j = 1; j <=N; ++j)
                {
                    if (i * j == N)
                        dividers++;
                }
            }

            return dividers;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson1
{
    public class Solution
    {
        public int solution(int N)
        {
            int maxO = 0;
            int curO = 0;
            bool gapStarted = false;

            do
            {
                int bin = N % 2;
                N /= 2;

                if(bin == 1)
                {
                    if (curO > maxO)
                    {
                        maxO = curO;
                    }
                    curO = 0;
                    gapStarted = true;
                }
                else if(gapStarted)
                {
                    curO++;
                }

            } while (N != 0);

            return maxO;
        }
        
    }
}

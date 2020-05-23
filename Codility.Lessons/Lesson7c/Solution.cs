using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson7c
{
    public class Solution
    {
        public int solution(string S)
        {
            int opened = 0;
            foreach (var c in S)
            {
                if (c == '(')
                    opened++;
                if(c == ')')
                {
                    if (opened == 0)
                        return 0;
                    else
                        opened--;
                }
            }

            return opened == 0 ? 1 : 0;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson3a
{
    public class Solution
    {
        public int solution(int X, int Y, int D)
        {
            int d = Y - X;
            return (d / D) + (d % D == 0 ? 0 : 1);
        }
        
    }
}

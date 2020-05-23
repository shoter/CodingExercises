using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson6d
{
    public class Solution
    {
       public int solution(int[] A)
        {
            if (A.Length < 3)
                return 0;

            List<long> sorted = A.Select(x => (long)x).ToList();
            sorted.Sort();

            for(int i = 0; i < A.Length - 2; ++i)
            {
                long x = sorted[i];
                long y = sorted[i + 1];
                long z = sorted[i + 2];
                if (x + y > z && x + z > y && z + y > x)
                    return 1;
            }
            return 0;


        }

        public int brute(int[] A)
        {
            for(int x=  0; x< A.Length; ++ x)
                for(int y= 0;y < A.Length; ++ y)
                    for(int z = 0; z < A.Length; ++ z)
                    {
                        if (x == y || y == z || z == x)
                            continue;

                        if (x + y > z && x + z > y && z + y > x)
                            return 1;
                    }
            return 0;
        }
    }
}

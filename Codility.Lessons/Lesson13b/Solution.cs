using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson13b
{
    public class Solution
    {
        public int[] solution(int[] A, int [] B)
        {
            int[] possibilities = new int[50001];
            int maxRungs = 2;
            possibilities[1] = 1;
            possibilities[2] = 2;
            int[] R = new int[A.Length];

            int maxPowa = 1;
            for (int x = 0; x < 30; ++x)
                maxPowa *= 2;

            for (int p = 3; p <= 50000; ++p)
                possibilities[p] = (possibilities[p - 1] + possibilities[p - 2]) % maxPowa;

            for(int i = 0; i < A.Length; ++i)
            {
                int rungs = A[i];

                int pow = 1;

                for (int x = 0; x < B[i]; ++x)
                    pow *= 2;

               /* for(int x = 3; x <= rungs; ++x)
                {
                    possibilities[x] = (possibilities[x - 1] + possibilities[x - 2]) % pow;
                }*/

                R[i] = possibilities[rungs] % pow;
            }

            return R;

        }
        
    }
}

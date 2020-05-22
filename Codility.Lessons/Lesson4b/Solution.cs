using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson4b
{
    public struct Field
    {
        public int version;
        public int value;
    }
    public class Solution
    {
        public int[] solution(int N, int[] A)
        {
            Field[] C = new Field[N];
            int cversion = 0;
            int max = 0;
            int b = 0;
            for(int i = 0;i < A.Length; ++i)
            {
                if (A[i] == N + 1)
                {
                    b = max;
                    cversion++;
                }
                else
                {
                    if(C[A[i] - 1].version != cversion)
                    {
                        C[A[i] - 1].value = b;
                        C[A[i] - 1].version = cversion;
                    }
                    C[A[i] - 1].value++;
                    if (C[A[i] - 1].value > max)
                        max = C[A[i] - 1].value;
                }
            }

            return C.Select(x => x.version == cversion ? x.value : b).ToArray();

        }
        
    }
}

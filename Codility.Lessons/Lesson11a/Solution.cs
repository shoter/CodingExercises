using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson11a
{
    public class Solution
    {
        public int[] solution(int[] A)
        {
            Dictionary<int, int> resultDick = new Dictionary<int, int>();
            Dictionary<int, int> strength = new Dictionary<int, int>();
            List<int> sorted = A.Distinct().ToList();
            sorted.Sort();

            for(int i = 0; i < A.Length; ++i)
            {
                resultDick[A[i]] = A.Length;
                if (strength.ContainsKey(A[i]) == false)
                    strength[A[i]] = 0;

                strength[A[i]] += 1;
            }

            for(int i = 0; i < sorted.Count; ++i)
            {
                int s = sorted[i];
                int l = sorted.Last();
                int str = strength[s];

                /*if (i > 0 && i != sorted.Count - 1 && s == sorted[i - 1])
                    continue;*/

                while(s <= l)
                {
                    if(resultDick.ContainsKey(s))
                    {
                        resultDick[s] -= str;
                    }
                    s += sorted[i];
                }
            }

            int[] R = new int[A.Length];
            for(int i = 0;i < A.Length; ++i)
            {
                R[i] = resultDick[A[i]];
            }

            return R;
        }

        public int[] brute(int[] A)
        {
            int[] R = new int[A.Length];
            for(int i =0;i < A.Length; ++i)
            {
                int a = A[i];
                int result = 0;
                for(int j = 0; j < A.Length; ++j)
                {
                    if (i == j)
                        continue;
                    int b = A[j];
                    
                    if(a % b != 0)
                    {
                        result++;
                    }

                }

                R[i] = result;
            }

            return R;
        }
        
    }
}

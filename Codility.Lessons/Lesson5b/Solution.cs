using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson5b
{
    public class Solution
    {
        public int[] translate(string S)
        {
            var d = new Dictionary<char, int>() { { 'A', 0 }, { 'C', 1 }, { 'G', 2 }, { 'T', 3 } };
            return S.Select(c => d[c]).ToArray();
        }

        public int[] solution(string S, int[] P, int[] Q)
        {
            int[] R = new int[P.Length];
            int[] numbers = translate(S);

            int[,] distance = new int[S.Length, 4];
            int[] cpos = new int[4];
            for (int i = 0; i < 4; ++i)
                cpos[i] = -1;

            for(int i = 0;i < S.Length; ++i)
            {
                cpos[numbers[i]] = i;

                for (int x = 0; x < 4; ++x)
                {
                    if (cpos[x] != -1)
                        distance[i, x] = i - cpos[x];
                    else
                        distance[i, x] = -1;
                }
            }

            for(int i = 0; i < Q.Length; ++i)
            {
                int d = Q[i] - P[i];
                for(int x = 0;x < 4; ++x)
                {
                    if(distance[Q[i], x] != -1 && distance[Q[i], x] <= d)
                    {
                        R[i] = x + 1;
                        break;
                    }
                }
            }

            return R;
        }

        public int[] brute(string S, int[] P, int[] Q)
        {
            var n = new Dictionary<char, int>() { { 'A', 0 }, { 'C', 1 }, { 'G', 2 }, { 'T', 3 } };
            int[] R = new int[P.Length];
            for (int i = 0; i < P.Length; ++i)
            {
                int min = 5;
                for (int x = P[i]; x <= Q[i]; ++x)
                {
                    if (n[S[x]] < min)
                        min = n[S[x]];
                }
                R[i] = min + 1;
            }

            return R;
        }
    }
}

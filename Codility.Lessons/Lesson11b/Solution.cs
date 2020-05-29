using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson11b
{
    public class Solution
    {
        int[] sf = null;
        bool[] s = null;
        public int[] solution(int N, int[] P, int[] Q)
        {
            int[] R = new int[P.Length];
            int[] prefix = new int[N + 1];
            sieve(N);
            factors(N);

            for(int i = 2; i <= N; ++ i)
            {
                prefix[i] = prefix[i - 1] + (IsPrime(i) ? 1 : 0);
            }

            for(int i = 0;i < P.Length; ++i)
            {
                int p = P[i];
                int q = Q[i];

                int sum = prefix[q];
                sum -= prefix[p - 1];

                R[i] = sum;
            }

            return R;
        }

        public bool[] sieve(int N)
        {
            bool[] R = new bool[N + 1];
            bool[] used = new bool[N + 1];

            R[1] = false;

            for(int i = 2; i <= N; ++i)
            {
                if (used[i])
                    continue;
                else
                {
                    int s = i;
                    R[i] = true;
                    used[i] = true;
                    while (s <= N)
                    {
                        used[s] = true;
                        s += i;
                    }
                }
            }

            return s = R;
        }

        public int[] factors(int N)
        {
            int[] smallestFactor = new int[N + 1];
            bool[] used = new bool[N + 1];
            smallestFactor[0] = 0;
            smallestFactor[1] = 1;


            for (int i = 2; i <= N; ++i)
            {
                if (used[i])
                    continue;
                else
                {
                    int s = i;
                    smallestFactor[i] = i;
                    used[i] = true;
                    while (s <= N)
                    {
                        if (used[s] == false)
                        {
                            smallestFactor[s] = i;
                            used[s] = true;
                        }
                        s += i;
                    }
                }
            }

            return sf = smallestFactor;
        }

        public bool IsPrime(int X)
        {
            int div1 = sf[X];
            int div2 = sf[X / div1];

            return s[div1] && s[div2] && div1 * div2 == X;
        }


        public int[] brute(int N, int[] P, int []Q)
        {
            int[] R = new int[P.Length];
            sieve(N);
            factors(N);

            for(int i = 0; i < P.Length;++i)
            {
                int p = P[i];
                int q = Q[i];
                int fs = 0;
                for (int x = p; x <= q; ++x)
                    if (IsPrime(x))
                        fs++;
                R[i] = fs;
            }

            return R;
        }
        
    }
}

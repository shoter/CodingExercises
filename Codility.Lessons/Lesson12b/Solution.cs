using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson12b
{

    public class Solution
    {
        public struct sieveReturn
        {
            public bool[] R;
            public List<int> Primes;
        }


        public int solution(int[] A, int[] B)
        {
            int count = 0;
            for(int i = 0;i < A.Length; ++i)
            {
                count += resolve(A[i], B[i]) ? 1 : 0;

            }
            return count;
                    }

        public bool resolve(int A,int B)
        {
            if (A == B)
                return true;

            int max = Math.Max(A, B);
            int min = Math.Min(A, B);

            int g = gcd(A, B);

            if (g == 1)
                return false;

            return correct(g, A / g) && correct(g, B/ g) ;
        }

        public bool correct(int g, int x)
        {

            while (g % x != 0)
            {
                int r = gcd(g, x);
                if (r == 1)
                    return false;
                x /= r;
            }

            return true;
        }

        public bool hasProperDivisor(HashSet<int> divs, int x)
        {
            bool has = false;
            foreach (var d in divs)
            {
                if (d % x == 0)
                    return true;
                if (x % d == 0 && d != 1)
                    return hasProperDivisor(divs, x / d);
            }

            return has;
        }


        public sieveReturn sieve(int N)
        {
            bool[] R = new bool[N + 1];
            List<int> Primes = new List<int>();
            bool[] chk = new bool[N + 1];
            R[0] = R[1] = false;
            chk[0] = chk[1] = true;
            for (int i = 2; i <= N; ++i)
            {
                if (chk[i])
                    continue;
                else
                {
                    chk[i] = true;
                    R[i] = true;
                    Primes.Add(i);
                    for (int x = i * 2; x <= N; x += i)
                        chk[x] = true;
                }
            }

            sieveReturn ret = new sieveReturn();
            ret.R = R;
            ret.Primes = Primes;

            return ret;
        }

        public int[] divisors(int N)
        {
            int[] R = new int[N + 1];

            for (int i = 0; i <= N; ++i)
                R[i] = int.MaxValue;

            bool[] chk = new bool[N + 1];
            R[0] = R[1] = 1;
            chk[0] = chk[1] = true;
            for (int i = 2; i <= N; ++i)
            {
                if (chk[i])
                    continue;
                else
                {
                    chk[i] = true;
                    R[i] = i;
                    for (int x = i * 2; x <= N; x += i)
                    {
                        if (chk[x] == false)
                        {
                            R[x] = i;
                        }
                        chk[x] = true;
                    }
                }
            }

            return R;
        }

        public int gcd(int a, int b)
        {
            int max = Math.Max(a, b);
            int min = Math.Min(a, b);
            if (max % min == 0)
                return min;
            return gcd(min, max % min);
        }


        public int brute(int[] A, int[] B, int N)
        {

            bool[] primes = sieve(N).R;
            int[] divs = divisors(N);

            int count = 0;

            for (int i = 0; i < A.Length; ++i)
            {
                int a = A[i];
                int b = B[i];

                List<int> bDivs = new List<int>();
                List<int> aDivs = new List<int>();

                while (a > 1)
                {
                    int d = divs[a];
                    if (primes[d])
                        aDivs.Add(d);
                    a /= d;
                }
                while (b > 1)
                {
                    int d = divs[b];
                    if (primes[d])
                        bDivs.Add(d);
                    b /= d;
                }

                aDivs = aDivs.Distinct().ToList();
                bDivs = bDivs.Distinct().ToList();

                aDivs.Sort();
                bDivs.Sort();

                if (aDivs.Count == bDivs.Count)
                {
                    bool equal = true;
                    for (int x = 0; x < aDivs.Count; ++x)
                    {
                        if (aDivs[x] != bDivs[x])
                        {
                            equal = false;
                            break;
                        }
                    }

                    if (equal)
                        count++;
                }

            }

            return count;

        }

    }
}

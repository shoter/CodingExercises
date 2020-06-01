using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson12a
{
    public class Solution
    {
        public int solution(int N, int M)
        {
            int max = Math.Max(N, M);
            int min = Math.Min(N, M);

            int g = gcd(max, min);

            return N / g;
        }

        public int brute(int N, int M)
        {
            bool[] eaten = new bool[N];

            int index = 0;
            int count = 0;
            while(eaten[index] == false)
            {
                eaten[index] = true;
                count++;

                index += M;
                index %= N;
            }

            return count;
        }

        public int gcd(int a, int b)
        {
            // a bigger than b
            if (a % b == 0)
                return b;
            return gcd(b, a % b);
        }

        public int lastIndex(int N, int M)
        {
            bool[] eaten = new bool[N];

            int index = 0;
            int count = 0;
            while (eaten[index] == false)
            {
                eaten[index] = true;
                count++;

                index += M;
                index %= N;
            }

            return index;
        }
    }
}

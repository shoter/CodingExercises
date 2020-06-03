using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson13a
{
    public class Solution
    {
       public int solution(int[] A)
        {
            if (A.Length == 0)
                return 1;

            int size = A.Length + 2;
            int[] moves = new int[size];
            for (int i = 1; i < moves.Length; ++i)
                moves[i] = int.MaxValue;

            int[] fibs = fib(size);

            for(int i = 0;i < moves.Length - 1; ++i)
            {
                int m = moves[i];

                if (m == int.MaxValue)
                    continue;

                foreach(var f in fibs)
                {
                    int pos = i + f;
                    int apos = i + f - 1;
                    if (pos == size - 1)
                        moves[pos] = Math.Min(moves[pos], m + 1);
                    else if (pos < size && A[apos] == 1)
                        moves[pos] = Math.Min(moves[pos], m + 1);
                }
            }

            if (moves[size - 1] == int.MaxValue)
                return -1;
            return moves[size - 1];
        }

        public int[] fib(int maxN)
        {
            List<int> fib = new List<int>();

            fib.Add(1);
            fib.Add(1);

            while(true)
            {
                int f1 = fib.Last();
                int f2 = fib[fib.Count - 2];
                int f = f1 + f2;

                if (f < maxN)
                {
                    fib.Add(f);
                }
                else
                    break;
            }

            return fib.ToArray();
        }
    }
}

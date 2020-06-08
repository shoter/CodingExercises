using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson14b
{
    public class Solution
    {
        public struct Nail : IComparable
        {
            public int id;
            public int position;

            public Nail(int id, int pos)
            {
                this.id = id;
                this.position = pos;
            }

            public int CompareTo(object obj)
            {
                Nail other = (Nail)obj;
                return position.CompareTo(other.position);
            }
        }


        List<int>[] nailPlanks;
        public int solution(int[] A, int[] B, int[] C)
        {
            int min = 1;
            int max = C.Length;
            int earliest = int.MaxValue;

            while(min <= max)
            {
                int mid = (min + max) / 2;
                bool ok = isPossible(A, B, C, mid);

                if (ok)
                {
                    earliest = mid;
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            if (earliest == int.MaxValue)
                return -1;

            return earliest;
        }

        public bool isPossible(int[] A, int[] B, int[] C, int usedNails)
        {
            int[] nails = new int[C.Length * 2 + 1];

            for(int i = 0;i < usedNails; ++i)
            {
                nails[C[i]] = 1;
            }

            for (int x = 1; x <= C.Length * 2; ++x)
                nails[x] += nails[x - 1];

            bool isPos = true;

            for(int i = 0;i < A.Length && isPos; ++i)
            {
                isPos = nails[A[i] - 1] != nails[B[i]];
            }

            return isPos;
        }

    }
}

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
            List<Nail> nails = new List<Nail>(C.Length);

            for (int i = 0; i < C.Length; ++i)
                nails.Add(new Nail(i, C[i]));

            nails.Sort();

            int earliestPossible = FindFirstPossibleNail(A[0], B[0], nails, -1);

            for (int i = 1; i < A.Length; ++i)
            {
                if (earliestPossible == int.MaxValue)
                    return -1;

                earliestPossible = FindFirstPossibleNail(A[i], B[i], nails, earliestPossible);
            }

            if (earliestPossible == int.MaxValue)
                return -1;

            return earliestPossible + 1;
        }

        public int FindFirstPossibleNail(int start, int end, List<Nail> nails, int previousResult)
        {
            int min = 0;
            int max = nails.Count - 1;
            int earliest = int.MaxValue;

            while(min <= max)
            {
                int mid = (min + max) / 2;

                if(nails[mid].position < start)
                {
                    min = mid + 1;
                    
                }
                else if(nails[mid].position > end)
                {
                    max = mid - 1;
                }
                else
                {
                    earliest = mid;
                    max = mid - 1;
                }
            }

            if (earliest == int.MaxValue)
                return int.MaxValue;

            int earliestIndex = nails[earliest].id;

            for(int i = earliest + 1; i < nails.Count; ++i)
            {
                if (nails[i].position > end)
                    return Math.Max(earliestIndex, previousResult);

                earliestIndex = Math.Min(earliestIndex, nails[i].id);

                if (earliestIndex < previousResult)
                    return previousResult;
            }

            return Math.Max(earliestIndex, previousResult);
        }
    }
}

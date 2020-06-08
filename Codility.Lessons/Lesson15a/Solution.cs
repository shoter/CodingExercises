using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson15a
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int left = 0;
            int right = A.Length - 1;

            int? pl = null;
            int? pr = null;

            int count = 0;

            while (left <= right)
            {
                if (A[left] == int.MinValue)
                {
                    if (A[left] == pl)
                    {
                        left++;
                        continue;
                    }
                    left++;
                    count += 1;
                    pl = int.MinValue;
                    continue;
                }

                int l = Math.Abs(A[left]);
                int r = Math.Abs(A[right]);

                if (l == pl)
                {
                    left++;
                    continue;
                }
                if (r == pr)
                {
                    right--;
                    continue;
                }

                 if (l > r)
                {
                    count += 1;
                    left++;
                    pl = l;
                }
                else if (r > l)
                {
                    count += 1;
                    right--;
                    pr = r;

                }
                else if (l == r) // for clarity
                {
                    left++;
                    right--;
                    ++count;
                    pl = l;
                    pr = r;
                }
            }

            return count;

        }

        public int brute(int[] A)
        {
            HashSet<uint> uniques = new HashSet<uint>();
            foreach (var a in A)
                uniques.Add((uint)Math.Abs((long)a));

            return uniques.Count;
        }

    }
}

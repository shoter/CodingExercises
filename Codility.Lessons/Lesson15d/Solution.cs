using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson15d
{
    public class Solution
    {
        public int solution(int[] A)
        {
            List<int> numbers = new List<int>(A.Length);
            for (int i = 0; i < A.Length; ++i)
                numbers.Add(A[i]);

            numbers.Sort();

            if (numbers[0] >= 0)
                return numbers[0] * 2;
            if (numbers[numbers.Count - 1] <= 0)
                return (-numbers[numbers.Count - 1] * 2);

            int max = A.Length - 1;
            int min = 0;

            int minAbs = Math.Min(Math.Abs(numbers[min] * 2), Math.Abs(numbers[max] * 2));
            while(min <= max)
            {
                int nmin = numbers[min];
                int nmax = numbers[max];

                if (nmin > 0)
                    break;
                if (nmax < 0)
                    break;

                minAbs = Math.Min(minAbs, Math.Abs(nmax + nmin));

                if(nmax >= -nmin)
                {
                    max--;
                    minAbs = Math.Min(minAbs, Math.Abs(numbers[max] * 2));
                }
                else
                {
                    min++;
                    minAbs = Math.Min(Math.Abs(numbers[min] * 2), minAbs);

                }
            }

            return minAbs;
        }

        public int brute(int[] A)
        {
            int minAbs = int.MaxValue;

            for(int i = 0;i < A.Length; ++i)
                for(int j = 0;j < A.Length; ++j)
                {
                    minAbs = Math.Min(Math.Abs(A[i] + A[j]), minAbs);
                }

            return minAbs;
        }
        
    }
}

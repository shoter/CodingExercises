using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson15c
{
    public class Solution
    {
        public struct Number : IComparable
        {
            public int value;
            public int pos;

            public Number(int v, int p)
            {
                value = v;
                pos = p;
            }

            public int CompareTo(object obj)
            {
                Number other = (Number)obj;
                return value.CompareTo(other.value);
            }

            public override string ToString() => $"{value} - {pos}";
        }

        public int solution(int[] A)
        {
            if (A.Length <= 2)
                return 0;

            List<Number> Numbers = new List<Number>(A.Length);
            for (int i = 0; i < A.Length; ++i)
                Numbers.Add(new Number(A[i], i));

            Numbers.Sort();

            int count = 0;
            for(int p = 0; p < A.Length - 2; ++p)
            {
                int nc =  possibleSolutions(Numbers, p);

                if (nc == -1)
                    continue;
                count += nc;
            }

            return count;
        }

        public int possibleSolutions(List<Number> numbers, int p)
        {
            int count = 0;
            int previousR = -1;
            for(int q = p + 1; q < numbers.Count - 1; ++ q)
            {
                // pomiedzy tymi indexami znajduje sie pierwsze r.
                int max = numbers.Count - 1;
                int min = Math.Max(previousR, q + 1);

                int rMaxValue = numbers[p].value + numbers[q].value - 1;
                int r = findHighestPossibleR(numbers, min, max, rMaxValue);

                if (r != -1)
                {
                    previousR = r;
                    Debug.Assert(r > q);
                    Debug.Assert(r < numbers.Count);

                    count += (r - q);
                }

            }

            return count;
        }

        public int findHighestPossibleR(List<Number> numbers, int min, int max, int maxValue)
        {
            int lastR = -1;
            while(min <= max)
            {
                int mid = (min + max) / 2;
                bool ok = numbers[mid].value <= maxValue;

                if(ok)
                {
                    lastR = mid;
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            return lastR;
        }





        public int brute(int[] A)
        {
            int count = 0;
            for(int i = 0;i < A.Length; ++i)
            {
                for(int j = i + 1;j < A.Length; ++j)
                {
                    for(int k = j + 1; k < A.Length; ++k)
                    {
                        int a = A[i];
                        int b = A[j];
                        int c = A[k];

                        if (a + b > c && a + c > b && b + c > a)
                            count++; 
                    }
                }
            }

            return count;
        }
        
    }
}

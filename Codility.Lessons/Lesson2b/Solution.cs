using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson2b
{
    public class Solution
    {
        public int solution(int[] A)
        {
            //merge(A, 0, A.Length);
            return s2(A);
            
        }

        public int s3(int[] A)
        {
            int a = 0;

            for(int i = 0;i < A.Length; ++i)
            {
                a ^= A[i];
            }

            return a;
        }

        public int s1(int[] A)
        {
            quickSort(A, 0, A.Length);
            for (int i = 0; i < A.Length - 1; i += 2)
            {
                if (A[i] != A[i + 1])
                    return A[i];
            }
            return A[A.Length - 1];
        }

        public int s2(int[] A)
        {
            HashSet<int> set = new HashSet<int>();
            for(int i = 0;i < A.Length; ++i)
            {
                if (!set.Add(A[i])) 
                {
                    set.Remove(A[i]);
                }
            }

            return set.First();
        }

        public void quickSort(int[] A, int start, int end)
        {
            if(end - start > 1)
            {
                int q = partition(A, start, end);
                quickSort(A, start, q);
                quickSort(A, q + 1, end);
            }

        }

        public int partition(int[] A, int start, int end)
        {
            int x = A[end - 1];
            int l = 0;
            int r = 0;
            for (int i = 0; i < end - 1; ++i)
            {
                if (A[i] <= x)
                {
                    swap(A, i, l);
                    ++l;
                }

                ++r;
            }

            swap(A, l, end - 1);
            return l;
        }

        public void swap(int[] A, int x, int y)
        {
            int t = A[x];
            A[x] = A[y];
            A[y] = t;
        }

        public void merge(int[] A, int start, int end)
        {
            if (end - start <= 1)
                return;
            int mid = (start + end) / 2;
            merge(A, start, mid);
            merge(A, mid, end);

            int l = start;
            int r = mid;

            if (A[r-1] <= A[r])
                return;

            while(l < mid && r < end)
            {
                int ln = A[l];
                int rn = A[r];

                if(ln <= rn)
                {
                    ++l;
                }
                else
                {
                    int temp = A[r];
                    for(int x = r; x > l; --x)
                    {
                        A[x] = A[x - 1];
                    }

                    A[l] = temp;
                    ++r;
                    mid++;
                    ++l;
                }
            }
        }
    }
}

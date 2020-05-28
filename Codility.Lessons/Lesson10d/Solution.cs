using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson10d
{
    public class Solution
    {
        public int solution(int[] A)
        {
            List<int> peaks = createPeaksPositions(A);
            var divs = dividers(A.Length).OrderBy(x => x);

            /* for (int x = 1; x < divs.Count; ++x)
             {
                 int d = divs[x];
                 for (int y = x + 1; y < divs.Count; ++y)
                 {
                     if (divs[y] % d == 0)
                         divs.RemoveAt(y);
                 }
             }*/

            if (peaks.Count == 0)
                return 0;

            foreach (var d in divs)
            {
                int prevBlock = -1;
                int lastBlock = (A.Length - 1) / d;
                bool possible = true;
                foreach (var peak in peaks)
                {
                    int currentBlock = peak / d;
                    if (currentBlock - prevBlock > 1)
                    {
                        possible = false;
                        break;
                    }
                    prevBlock = currentBlock;
                }

                if (possible && lastBlock == prevBlock)
                    return A.Length / d;
            }

            return 1;
        }

        public List<int> dividers(int N)
        {
            int i = 1;
            List<int> dividers = new List<int>();

            while (i * i <= N)
            {
                if (N % i == 0)
                {
                    dividers.Add(i);
                    if (N / i != i)
                        dividers.Add(N / i);
                }

                ++i;
            }

            return dividers;
        }

        public bool[] createPeaks(int[] A)
        {
            bool[] peaks = new bool[A.Length];

            for (int i = 1; i < A.Length - 1; ++i)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                    peaks[i] = true;
            }

            return peaks;
        }

        public List<int> createPeaksPositions(int[] A)
        {
            List<int> peaks = new List<int>();

            for (int i = 1; i < A.Length - 1; ++i)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                    peaks.Add(i);
            }

            return peaks;
        }

        public int brute(int[] A)
        {
            bool[] peaks = createPeaks(A);
            if (peaks.Any(x => x) == false)
                return 0;
            int possibleBlocks = 0;

            int maxD = 0;

                
            for(int d = 1; d <= A.Length; ++d)
            {
                if (A.Length % d != 0)
                    continue;

                int[] peakCount = new int[A.Length / d];

                for (int i = 0; i < A.Length; ++i)
                {
                    int block = i / d;
                    if (peaks[i])
                        peakCount[block]++;
                }

                bool possible = true;
                for(int i = 0;i < peakCount.Length;++i)
                {
                    if(peakCount[i] == 0)
                    {
                        possible = false;
                        break;
                    }    
                }
                if (possible)
                    maxD = Math.Max(maxD, peakCount.Length);
            }

            return maxD;
        }

    }
}

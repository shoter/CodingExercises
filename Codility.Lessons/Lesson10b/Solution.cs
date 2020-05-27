using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson10b
{
    public class Solution
    {
        public int solution(int[] A)
        {
            List<int> peaks = new List<int>();
            int minDistance = int.MaxValue;
            int maxDistance = 0;

            for (int i = 1; i < A.Length - 1; ++i)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                {
                    if (peaks.Count > 0)
                    {
                        minDistance = Math.Min(minDistance, i - peaks.Last());
                        maxDistance = Math.Max(maxDistance, i - peaks.Last());
                    }


                    peaks.Add(i);

                }
            }

            if (peaks.Count <= 1)
                return peaks.Count;


            int minFlags = Math.Min(peaks.Count, minDistance);
            int maxFlags = peaks.Count;
            int tFlags = maxFlags;
            while (true)
            {
                int nFlags = minFlags * 2;
                if (nFlags < tFlags / 2)
                {
                    minFlags *= 2;
                    tFlags /= 2;
                    minDistance *= 2;
                }
                else
                    break;
            }

            int min = minFlags;
            int max = maxFlags;

            if (min == max)
                return min;

            if (Can(peaks, max))
                return max;

            while(true)
            {
                int current = (min + max) / 2;

                if (min == max)
                    return current + (Can(peaks,current) ? 0 : -1);

                if(Can(peaks, current))
                {
                    min = Math.Max(current, min + 1);
                }
                else
                {
                    max = Math.Min(current, max - 1);
                }
            }
        }

        public bool Can(List<int> peaks, int K)
        {
            int currentSum = 0;
            int placedFlags = 1;
            int peaksLeft = peaks.Count - 1;

            for(int i = 1; i < peaks.Count; ++i)
            {
                currentSum += (peaks[i] - peaks[i - 1]);
                peaksLeft--;

                if(currentSum >= K)
                {
                    placedFlags++;
                    currentSum = 0;
                    
                    if(placedFlags == K)
                    {
                        return true;
                    }
                }

                if (placedFlags + peaksLeft < K)
                    return false;
            }

            return false;
        }

        public int brute(int[] A)
        {
            List<int> peaks = new List<int>();

            for (int i = 1; i < A.Length - 1; ++ i)
            {
                if (A[i] > A[i - 1] && A[i] > A[i + 1])
                    peaks.Add(i);
            }

            int maxFlagsUsed = 0;

            for (int K = 1; K <= peaks.Count; ++K)
            {
                int flagsUsed = 0;
                int lastFlagUsedOn = 0 - K - 1 ;

                for(int i = 0;i < peaks.Count; ++i)
                {
                    if(peaks[i] - lastFlagUsedOn >= K)
                    {
                        flagsUsed++;
                        lastFlagUsedOn = peaks[i];

                        if (flagsUsed == K)
                            break;
                    }
                }

                maxFlagsUsed = Math.Max(flagsUsed, maxFlagsUsed);
            }

            return maxFlagsUsed;
        }
    }
}

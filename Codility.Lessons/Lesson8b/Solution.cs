using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson8b
{
    public class Solution
    {
        public int solution(int[] A)
        {
            int value = 0;
            int size = 0;

            int leaderCount = 0;

            int result = 0;

            for (int i = 0; i < A.Length; ++i)
            {
                if (size == 0)
                {
                    value = A[i];
                    size++;
                }
                else
                {
                    if (value == A[i])
                        size++;
                    else
                        size--;
                }
            }

            int count = 0;
            int leader = -1;
            int border = A.Length / 2 + 1;
            for (int i = 0; i < A.Length; ++i)
            {
                if (value == A[i])
                {
                    count++;
                    leaderCount++;
                }

                if (count >= border)
                    leader = value;
                    
            }

            if (leader == -1)
                return 0;


            count = 0;
            for(int i = 0;i < A.Length; ++i)
            {
                if (A[i] == leader)
                    count++;

                bool isLeftLeader = count >= (i + 1) / 2 + 1;

                int rleaders = leaderCount - count;
                int rSize = A.Length - i - 1;

                bool isRightLeader = rleaders >= (rSize) / 2 + 1;

                if (isLeftLeader && isRightLeader)
                    result++;
            }

            return result;
        }

        public int brute(int[] A)
        {
            int leaders = 0;

            for(int i = 0;i < A.Length - 1; ++i)
            {
                if (isCorrect(A, i))
                    leaders++;
            }

            return leaders;

        }

        public bool isCorrect(int[] A,int sep)
        {
            Dictionary<int, int> left = new Dictionary<int, int>();
            int lsize = 0, rsize = 0;
            Dictionary<int, int> right = new Dictionary<int, int>();


            for(int i = 0;i <= sep; ++i)
            {
                int x = A[i];
                if (!left.ContainsKey(x))
                    left[x] = 1;
                else
                    left[x]++;

                lsize++;
            }
            for (int i = sep + 1; i < A.Length; ++i)
            {
                int x = A[i];
                if (!right.ContainsKey(x))
                    right[x] = 1;
                else
                    right[x]++;

                rsize++;
            }

            int lmaxN = 0, lmaxC = 0, rmaxN = 0, rmaxC = 0;

            foreach(var l in left)
            {
                if(l.Value> lmaxC)
                {
                    lmaxC = l.Value;
                    lmaxN = l.Key;
                }
            }

            foreach(var r in right)
            {
                if(r.Value > rmaxC)
                {
                    rmaxC = r.Value;
                    rmaxN = r.Key;
                }
            }

            if (lmaxC < lsize / 2 + 1)
                return false;
            if (rmaxC < rsize / 2 + 1) 
                return false;

            return lmaxN == rmaxN;


        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson6b
{
    public class Solution
    {
        Queue<int> queue = new Queue<int>();
        Queue<int> biggestNegatives = new Queue<int>();

        bool canPutNumber(int number)
        {
            if (queue.Count < 3)
                return true;
            return queue.Peek() < number;
        }

        void sort()
        {
            List<int> n = queue.ToList();
            queue.Clear();
            n.Sort();
            n.ForEach(x => queue.Enqueue(x));
        }

        void sortNegative()
        {
            List<int> n = biggestNegatives.ToList();
            biggestNegatives.Clear();
            n.Sort();
            n.Reverse();

            n.ForEach(x => biggestNegatives.Enqueue(x));
        }

        void putNumber(int number)
        {
            bool shouldSort = queue.Count == 2;
            queue.Enqueue(number);
            if (queue.Count > 3)
                queue.Dequeue();

            sort();
        }

        bool canPutNegative(int number)
        {
            return number < 0 && (biggestNegatives.Count < 2 || biggestNegatives.Peek() > number);
        }

        void putNegative(int number)
        {
            bool shouldSort = biggestNegatives.Count == 1;
            biggestNegatives.Enqueue(number);
            if (biggestNegatives.Count > 2)
                biggestNegatives.Dequeue();

            sortNegative();
        }

        public int solution(int[] A)
        {
            for (int i = 0; i < A.Length; ++i)
            {
                int a = A[i];
                if (canPutNumber(a))
                    putNumber(a);

                if (canPutNegative(a))
                    putNegative(a);
            }

            sort();
            sortNegative();

            int? negFac = null;
            if (biggestNegatives.Count == 2)
            {
                negFac = biggestNegatives.Dequeue() * biggestNegatives.Dequeue() * queue.Last();
            }

            int fac = 1;

            while (queue.Any())
            {
                fac *= queue.Dequeue();
            }

            return Math.Max(negFac ?? int.MinValue, fac);

        }

    }
}

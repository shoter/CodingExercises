using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson7b
{
    public enum Direction
    {
        UP = 0,
        DOWN = 1
    }
    public class Solution
    {
       public int solution(int[] A, int [] B)
        {
            if (A.Length < 2)
                return A.Length;

            Stack<int> fishes = new Stack<int>();
            int alive = 0;

            for(int i = 0;i < A.Length; ++i)
            {
                Direction dir = (Direction)B[i];
                int s = A[i];

                if(dir == Direction.UP)
                {
                    while (fishes.Count > 0 && fishes.Peek() < s)
                        fishes.Pop();

                    if (fishes.Count == 0)
                        alive++;
                }
                else
                {
                    fishes.Push(s);
                }
            }


            return fishes.Count + alive;
        }
    }
}

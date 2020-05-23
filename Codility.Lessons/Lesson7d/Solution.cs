using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson7d
{
    public class Solution
    {
        public int solution(int[] H)
        {
            Stack<int> height = new Stack<int>();
            int blocks = 0;

            for(int i = 0;i < H.Length; ++i)
            {
                if (height.Count == 0)
                    height.Push(H[i]);
                else
                {
                    int h = height.Peek();

                    if (h < H[i])
                    {
                        height.Push(H[i]);
                    }
                    else if (h == H[i]) { } //nothing happens
                    else
                    {
                        while (h > H[i])
                        {
                            blocks++;
                            height.Pop();
                            if (height.Count == 0)
                                break;
                            h = height.Peek();
                        }

                        if (height.Count > 0 && height.Peek() != H[i])
                            height.Push(H[i]);

                        if (height.Count == 0)
                            height.Push(H[i]);
                    }
                }
            }

            return blocks + height.Count;

        }
        
    }
}

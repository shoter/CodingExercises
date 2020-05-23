using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson8a
{
    public class Solution
    {
        public int solution(int[] numbers)
        {
            int value = 0;
            int size = 0;

            for (int i = 0; i < numbers.Length; ++i)
            {
                if (size == 0)
                {
                    value = numbers[i];
                    size++;
                }
                else
                {
                    if (value == numbers[i])
                        size++;
                    else
                        size--;
                }
            }

            if (size == 0)
                return -1;

            int count = 0;
            int border = numbers.Length / 2 + 1;
            for (int i = 0; i < numbers.Length; ++i)
            {
                if (value == numbers[i])
                    count++;

                if (count >= border)
                    return i;
            }
            return -1;
        }
    }
}

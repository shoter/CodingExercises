using Codility.Lessons.Lesson4b;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson4c
{
    public class Solution
    {
        public int solution(int[] A)
        {
            // free field is pointing to occupied field
            Dictionary<int, int> fields = new Dictionary<int, int>();
            int pointer;

            for(int i = 0; i < A.Length; ++i)
            {
                int v = A[i];
                if (v < 1)
                    continue;

                if(fields.TryGetValue(v + 1, out pointer))
                {
                    fields[v] = pointer;
                }
                else
                {
                    fields[v] = v + 1;
                }
            }

            int field = 1;
            while(fields.TryGetValue(field, out pointer))
            {
                field = pointer;
            }

            return field;
        }
        
    }
}

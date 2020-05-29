using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    public class Erasto
    {
        public int[] solution(int N)
        {
            bool[] odd = new bool[N + 1];
            bool[] isFirst = new bool[N + 1];

            odd[1] = true;

            for(int i = 2; i <= N; ++i)
            {
                if (odd[i])
                    continue;
                else
                {
                    isFirst[i] = true;
                    for(int j = i * 2; j <= N; j += i)
                    {
                        odd[j] = true;
                    }
                }
            }

            List<int> result = new List<int>();
            for (int i = 1; i <= N; ++i)
                if (isFirst[i])
                    result.Add(i);

            return result.ToArray();
        }
        
    }
}

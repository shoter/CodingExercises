using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc
{
    public class BinarySearch
    {

        public int FindDiverge(bool[] array)
        {
            int min = 0;
            int max = array.Length - 1;

            while (true)
            {
                int current = (min + max) / 2;

                if (min == max)
                {
                    if (array[min])
                        return min;
                    else
                        return min - 1;
                }

                if (array[current])
                {
                    min = Math.Max(current, min + 1);
                }
                else
                {
                    max = Math.Min(current, max - 1);
                }
            }

        }
        
    }
}

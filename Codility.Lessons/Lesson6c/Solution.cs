using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Codility.Lessons.Lesson6c
{
    public class Solution
    {
        struct marking : IComparable
        {
            public int x;
            public int number;

            public int CompareTo(object obj)
            {
                return x.CompareTo(((marking)obj).x);
            }
        }
        public int solution(int[] A)
        {
            int[] starts = new int[A.Length];
            int[] ends = new int[A.Length];

            int belowZero = 0;

            for(int i = 0; i < A.Length; ++i)
            {
                int lx = i - A[i];

                if (lx < 0)
                    belowZero++;
                else
                    starts[lx]++;



                try
                {
                    checked
                    {
                        int rx = i + A[i];

                        if (rx < A.Length)
                            ends[rx]++;
                    }
                }
                catch(OverflowException)
                {
                    // nothing
                }

            }

            int actual = belowZero;
            int crossess = (belowZero * (belowZero - 1)) / 2;
            crossess = Math.Max(crossess, 0);

            for(int i = 0;i < A.Length; ++i)
            {
                crossess += actual * starts[i];
                int selfCrosses = (starts[i] * (starts[i] - 1)) / 2;
                if (selfCrosses > 0)
                    crossess += selfCrosses;

                actual += starts[i];
                actual -= ends[i];

                if (crossess > 10000000)
                    return -1;
            }


            return crossess;
        }

        struct Circle
        {
            public int x;
            public int r;
            public int lx;
            public int rx;

        }

        public int brute(int[] A)
        {
            List<Circle> circles = new List<Circle>();

            for (int i = 0; i < A.Length; ++i)
            {
                int x = i;
                int r = A[i];
                int lx = x - r;
                int rx = x + r;
                circles.Add(new Circle()
                {
                    x = x,
                    r = r,
                    lx = lx,
                    rx = rx
                });
            }
            int crosses = 0;

            for (int i = 0; i < circles.Count; ++i)
            {
                for (int y = i + 1; y < circles.Count; ++y)
                {
                    if (i == y)
                        continue;

                    Circle c1 = circles[i];
                    Circle c2 = circles[y];

                    if (c1.rx >= c2.lx && c1.lx <= c2.rx)
                        crosses++;

                    if (crosses > 10000000)
                        return -1;
                }
            }

            return crosses;

        }

    }
}

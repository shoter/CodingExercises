using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Codility.Lessons.Tests.Lesson5b
{
    public class Test
    {
        Codility.Lessons.Lesson5b.Solution s = new Lessons.Lesson5b.Solution();

        [Theory]
        [InlineData("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 }, new int[] { 2, 4, 1 })]
        public void test(string S, int[] P, int[] Q, int[] R)
        {
            Assert.Equal(R, s.solution(S, P, Q));

        }


        [Theory]
        [InlineData("CAGCCTA", new int[] { 2, 5, 0 }, new int[] { 4, 5, 6 }, new int[] { 2, 4, 1 })]
        public void testBrute(string S, int[] P, int[] Q, int[] R)
        {
            Assert.Equal(R, s.brute(S, P, Q));

        }

        [Fact]
        public void big()
        {
            Random r = new Random();
            var d = new Dictionary<int, char>() { { 0, 'A' }, { 1, 'C' }, {2,  'G' }, { 3, 'T' } };

            string S = "";

            for(int i =0; i < 100_000; ++i)
            {
                S += d[r.Next(0, 4)];
            }

            int size = 50_000;

            int[] P = new int[size];
            int[] Q = new int[size];

            for(int i = 0;i < 10;++i)
            {
                P[i] = r.Next(0, S.Length);
                Q[i] = r.Next(P[i], S.Length);
            }

            s.solution(S, P, Q);
        }

        [Fact]
        public void bigChecked()
        {
            Random r = new Random();
            var d = new Dictionary<int, char>() { { 0, 'A' }, { 1, 'C' }, { 2, 'G' }, { 3, 'T' } };


            string S = "";

            for (int i = 0; i < 100_000; ++i)
            {
                S += d[r.Next(0, 4)];
            }

            int size = 500;

            int[] P = new int[size];
            int[] Q = new int[size];

            for (int i = 0; i < size; ++i)
            {
                P[i] = r.Next(0, S.Length);
                Q[i] = r.Next(P[i], S.Length);
            }

            int[] R = s.solution(S, P, Q);

           
        }

        [Theory]
        [InlineData("ACGT", new int[] { 0, 1, 2, 3 })]
        [InlineData("ACGTACG", new int[] { 0, 1, 2, 3, 0, 1, 2 })]

        public void translateTest(string S, int[] R)
        {
            Assert.Equal(R, s.translate(S));
        }
        
    }
}

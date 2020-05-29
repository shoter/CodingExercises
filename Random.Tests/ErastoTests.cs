using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Misc.Tests
{
    public class ErastoTests
    {
        [Theory]
        [InlineData(10, new int[] { 1, 2, 3, 5, 7 })]
        public void test(int N, int[] R)
        {
            int[] r = new Erasto().solution(N);

            foreach (int x in r)
            {
                R.Single(o => o == x);
            }
        }

        [Fact]
        public void longS()
        {
            new Erasto().solution(1_000_000);
        }

    }
}

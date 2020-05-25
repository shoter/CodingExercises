using System;
using Codility.Lessons;

namespace Codility
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            for(int i = 1; i <= 100; ++i)
            {
                if (i % 4 == 0 || i % 7 == 0)
                    str += i.ToString();
            }

            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson7a
{
    public class Solution
    {
        public int solution(string S)
        {
            Dictionary<char, char> par = new Dictionary<char, char>()
            {
                {'{', '}' },
                {'[', ']' },
                {'(', ')' }
            };

            HashSet<char> ops = new HashSet<char>() { '(', '{', '[' };

            
            Stack<char> brackets = new Stack<char>();
            foreach(var c in S)
            {
                if(ops.Contains(c))
                {
                    brackets.Push(c);
                }
                else
                {
                    if (brackets.Count == 0)
                        return 0;

                    char top = brackets.Pop();
                    if (par[top] != c)
                        return 0;
                }
            }

            return brackets.Any() == false ? 1 : 0;
        }
        
    }
}

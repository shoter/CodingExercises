using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.Lessons.Lesson4a
{
    public enum LeafState : byte
    {
        Nothing = 0,
        HasLeaf = 1,
        HasConnection = 2,
    }
    public class Solution
    {
        LeafState[] leafState;
        void putLeaf(int pos)
        {
            int arrPos = pos - 1;
            if (leafState[arrPos] != LeafState.Nothing)
                return;

            leafState[arrPos] = LeafState.HasLeaf;
            if (arrPos == 0)
            {
                leafState[arrPos] = LeafState.HasConnection;
                if (leafState.Length > 1 && leafState[arrPos + 1] == LeafState.HasLeaf)
                    arrPos++;
            }
            while (arrPos > 0 && arrPos < leafState.Length && leafState[arrPos] == LeafState.HasLeaf && leafState[arrPos - 1] == LeafState.HasConnection)
            {
                leafState[arrPos] = LeafState.HasConnection;
                arrPos++;
            }
        }

        bool isCompleted() => leafState.Last() == LeafState.HasConnection;


        public int solution(int X, int[] A)
        {
            leafState = new LeafState[X];


            for(int i = 0;i < A.Length; ++i)
            {
                putLeaf(A[i]);
                if (isCompleted())
                    return i;
            }
            return -1;

            
            

        }
        
    }
}

using System;

namespace FrogRiverOne
{
    public class Solution
    {
        public int solution(int X, int[] A) {
            bool[] route = new bool[X + 1];
            for (int i = 0; i < A.Length; i++) {
                int step = A[i];
                if (!route[step]) {
                    route[step] = true;
                    if (--X == 0) return i;
                }
            }
            return -1;
        }
    }
}

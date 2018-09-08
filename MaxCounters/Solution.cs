using System;
using System.Linq;

namespace MaxCounters
{
    public class Solution
    {
        public int[] solution(int N, int[] A) {
            int[] result = new int[N];
            int max = 0;
            for (int i = 0; i < A.Length; i++) {
                if (A[i] <= N) {
                    max = Math.Max (++result[A[i] -1], max);
                }
                else
                    result = Enumerable.Repeat(max, N).ToArray();
            }
            return result;
        }
    }
}

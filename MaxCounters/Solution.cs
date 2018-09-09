using System;

namespace MaxCounters
{
    public class Solution
    {
        public int[] solution(int N, int[] A) {
            int[] result = new int[N];
            int currentMax = 0;
            int lastMax = 0;
            for (int K = 0; K < A.Length; K++) {
                if (A[K] >=0 && A[K] <= N) {
                    result[A[K] - 1] = Math.Max (result[A[K] - 1], lastMax);
                    currentMax = Math.Max (++result[A[K] - 1], currentMax);
                }
                else
                    lastMax = currentMax;
            }
            for (int i = 0; i < N; i++) {
                result[i] = Math.Max (result[i], lastMax);
            }
            return result;
        }
    }
}

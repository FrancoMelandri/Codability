using System;

namespace MissingInteger
{
    public class Solution
    {
        public int solution(int[] A) {
            const int MAX_ELEM = 1000000;
            const int NOT_FOUND = 1;
            System.Collections.Generic.List<int> map = new System.Collections.Generic.List<int>();

            for (int i = 0; i < A.Length; i++) {
                if (A[i] > 0) {
                    map.Add(A[i]);
                }
            }

            for (int i = 1; i <= MAX_ELEM; i++) {
                if (!map.Contains(i)) return i;
            }

            return NOT_FOUND;
        }
    }
}

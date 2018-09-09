using System;

namespace MissingInteger
{
    public class Solution
    {
        public int solution(int[] A) {
            const int MAX_ELEM = 1000000;
            const int NOT_FOUND = 1;
            System.Collections.Generic.Dictionary<int, int> map = new System.Collections.Generic.Dictionary<int, int>();

            for (int i = 0; i < A.Length; i++) {
                if (A[i] > 0) {
                    if (!map.ContainsKey(A[i]))
                        map.Add(A[i], A[i]);
                }
            }

            for (int i = 1; i <= MAX_ELEM; i++) {
                if (!map.ContainsKey(i)) return i;
            }

            return NOT_FOUND;
        }
    }
}

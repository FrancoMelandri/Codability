using System;

namespace OddOccurrencesInArray
{
    public class Solution
    {
        public int solution(int[] A) {
            const int MAX_ITEM_VALUE = 1000000000;
            int[] mask = new int[MAX_ITEM_VALUE];
            for(int i = 0; i < A.Length; i++) {
                mask[A[i]]++;
            }
            for(int i = 0; i < MAX_ITEM_VALUE; i++)
                if (mask[i] % 2 != 0)
                    return i;
            return 0;
        }
    }
}

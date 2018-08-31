using System;

namespace BinaryGap
{
    public class Solution
    {
        public int solution(int N) {
    
            const int CNT_ZEROES_CURRENT = 0;
            const int CNT_ZEROES_MAX = 1;

            int startingFrom = (int)Math.Floor(System.Math.Log(N, 2));            
            int[] counters = new[] { 0, 0 }; 

            for (int exp = startingFrom; exp >= 0; exp--) {
                counters = ((N & (1 << exp )) == 0) ?
                                 new [] { counters[CNT_ZEROES_CURRENT] + 1, counters[CNT_ZEROES_MAX] } :
                                 new [] { 0, Math.Max(counters[CNT_ZEROES_CURRENT], counters[CNT_ZEROES_MAX]) };
            }

            return counters[CNT_ZEROES_MAX];
        }
    }
}

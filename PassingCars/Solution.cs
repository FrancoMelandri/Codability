using System;

namespace PassingCars
{
    public class Solution
    {
        public int solution(int[] A) {
            int counter = 0;
            int step = 0;
            for (int i = 0; i < A.Length; i++) {
                if (A[i] == 0)
                    step++;
                else
                    counter += step;
            }
            return counter > 1000000000 ? -1 : counter;
        }
    }
}

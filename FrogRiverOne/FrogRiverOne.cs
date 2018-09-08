using System;

namespace FrogRiverOne
{
    public class Solution
    {
        public int solution(int X, int[] A) {
            int currentSteps = X;
            bool[] steps = new bool[currentSteps + 1];

            for (int i = 0; i < A.Length; i++) {
                if (!steps[A[i]]) {
                    steps[A[i]] = true;
                    currentSteps--;
                }

                if (currentSteps == 0) 
                    return i;
            }
            return -1;
        }
    }
}

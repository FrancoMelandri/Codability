using System;

namespace PassingCars
{
    public class Solution
    {
        public int solution(int[] A) {
            int counter = 0;
            for (int i = 0; i < A.Length; i++) {
                if (A[i] == 0) {
                    for (int j = i + 1; j < A.Length; j++) {
                        counter = counter + A[j]; 
                    }
                }
            }
            return counter;
        }
    }
}

using System;
using System.Linq;

namespace TapeEquilibrium
{
    public class Solution
    {
        public int solution(int[] A) {
            int minDiff = int.MaxValue;
            int sumLeft = 0;
            int sumRigth = A.Sum();

            for (int i = 1; i < A.Length; i++) {
                sumLeft += A[i - 1];
                sumRigth -= A[i - 1];
                minDiff = Math.Min(Math.Abs(sumLeft - sumRigth), minDiff);
            }
            return minDiff;
        }
    }
}

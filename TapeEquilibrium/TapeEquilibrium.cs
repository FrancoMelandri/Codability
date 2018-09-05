using System;
using System.Linq;

namespace TapeEquilibrium
{
    public class Solution
    {
        public int solution(int[] A) {
            int minDiff = int.MaxValue;
            Int64 sumLeft = 0;
            Int64 sumRigth = A.Sum(i => (Int64)i);

            for (int i = 1; i < A.Length; i++) {
                sumLeft += A[i - 1];
                sumRigth -= A[i - 1];
                minDiff = (int)Math.Min( Math.Abs(sumLeft - sumRigth), minDiff);
            }
            return minDiff;
        }
    }
}

using System;
using System.Linq;

namespace TapeEquilibrium
{
    public class Solution
    {
        public int solution(int[] A) {
            int minDiff = 99999999;
            for (int i = 1; i < A.Length; i++) {
                Int64 sumLeft = A.Take(i).Sum();
                Int64 sumRigth = A.Skip(i).Take(A.Length - i).Sum();
                Int64 diff = Math.Abs(sumLeft - sumRigth);
                if (diff < minDiff) minDiff = (int)diff;
                Console.Error.WriteLine("{0} > {1} > {2} : {3}", i, 
                                                                sumLeft, 
                                                                sumRigth,
                                                                diff);
            }
            return minDiff;
        }
    }
}

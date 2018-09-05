using System;

namespace PermCheck
{
    public class Solution
    {
        public int solution(int[] A) {
            Int64 length = A.Length;
            Int64 shouldBe = (length++ * length)/2;
            Int64 sum = 0;
            for(int i = 0; i < A.Length; i++)
                sum += A[i];
            return shouldBe == sum ? 1 : 0;
        }
    }
}

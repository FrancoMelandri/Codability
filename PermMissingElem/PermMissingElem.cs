using System;
using System.Linq;

namespace PermMissingElem
{
    public class Solution
    {
        public int solution(int[] A) {
            Int64 shouldBe = (Int64)((A.Length + 1) * (A.Length + 2))/2;
            Int64 sum = A.Sum(item => (Int64)item);
            return (int)(shouldBe - sum);
        }
    }
}

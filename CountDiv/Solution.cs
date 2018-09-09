using System;

namespace CountDiv
{
    public class Solution
    {
        public int solution(int A, int B, int K) {
            return (int)System.Math.Ceiling( (( ((double)B- A) + 1 ) / K));
        }
    }
}

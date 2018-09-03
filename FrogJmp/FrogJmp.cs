using System;

namespace FrogJmp
{
    public class Solution
    {
        public int solution(int X, int Y, int D) {            
            return (int)System.Math.Ceiling ((double)(Y - X)/D);
        }
    }
}

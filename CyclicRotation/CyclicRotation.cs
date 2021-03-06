﻿using System;
using System.Linq;

namespace CyclicRotation
{
    public class Solution
    {
        public int[] solution(int[] A, int K) {
            return A
                    .Concat(A)
                    .Skip(A.Length - (K % A.Length))
                    .Take(A.Length)
                    .ToArray();
        }
    }
}

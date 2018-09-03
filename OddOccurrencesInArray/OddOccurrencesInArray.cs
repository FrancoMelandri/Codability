using System;
using System.Linq;

namespace OddOccurrencesInArray
{
    public class Solution
    {
        public int solution(int[] A) {
            return A
                    .GroupBy(item => item)
                    .Select(group => new { Value = group.Key, Count = group.Count() })
                    .Where(item => item.Count % 2 != 0)
                    .Select(item => item.Value)
                    .First();
        }
    }
}

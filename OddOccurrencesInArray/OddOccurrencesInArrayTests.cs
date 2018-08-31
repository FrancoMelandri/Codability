using NUnit.Framework;

namespace OddOccurrencesInArray
{
    [TestFixture]
    public class OddOccurrencesInArrayTests
    {
        private Solution sut = new Solution();

        [Test]
        public void ShouldReturn7() 
        {
            int[] input = new int[] { 9, 3, 9, 3, 9, 7, 9 }; 
            Assert.AreEqual(7, new Solution().solution(input));
        }
    }
}
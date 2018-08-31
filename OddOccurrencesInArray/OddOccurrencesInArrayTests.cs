using NUnit.Framework;

namespace OddOccurrencesInArray
{
    [TestFixture]
    public class OddOccurrencesInArrayTests
    {
        private Solution sut = new Solution();

        [Test]
        public void ShouldReturnNoOdd() 
        {
            Assert.AreEqual(new Solution().solution(new int [] {}), 0);
        }
    }
}
using NUnit.Framework;

namespace TapeEquilibrium
{
    [TestFixture]
    public class TapeEquilibriumTests
    {
        [Test]
        public void ShouldReturnEmptyDetail() 
        {
            Assert.AreEqual(new Solution().solution(new int[] {}), 0);
        }
    }
}
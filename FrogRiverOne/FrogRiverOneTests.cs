using NUnit.Framework;

namespace FrogRiverOne
{
    [TestFixture]
    public class FrogRiverOneTests
    {
        [Test]
        public void ShouldReturnOk() 
        {
            Assert.AreEqual(new Solution().solution(0, new int[] {}), 0);
        }
    }
}
using NUnit.Framework;

namespace PermCheck
{
    [TestFixture]
    public class PermCheckTests
    {
        [Test]
        public void ShouldReturnEmptyDetail() 
        {
            Assert.AreEqual(new Solution().solution(new int[] {}), 0);
        }
    }
}
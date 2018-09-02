using NUnit.Framework;

namespace PermMissingElem
{
    [TestFixture]
    public class PermMissingElemTests
    {
        [Test]
        public void ShouldReturnEmptyDetail() 
        {
            Assert.AreEqual(new Solution().solution(new int[] {}), 0);
        }
    }
}
using NUnit.Framework;

namespace FrogJmp
{
    [TestFixture]
    public class FrogJmpTests
    {
        [Test]
        public void ShouldReturnEmptyDetail() 
        {
            Assert.AreEqual(new Solution().solution(0,0,0), 0);
        }
    }
}
using NUnit.Framework;

namespace FrogJmp
{
    [TestFixture]
    public class FrogJmpTests
    {
        private Solution sut = new Solution();

        [Test]
        public void ShouldReturn3Steps() 
        {
            Assert.AreEqual(3, sut.solution(10, 85, 30));
        }
    
        [Test]
        public void ShouldReturn10000000Steps() 
        {
            Assert.AreEqual(1000000, sut.solution(0, 1000000000, 1000));
        }
    }
}
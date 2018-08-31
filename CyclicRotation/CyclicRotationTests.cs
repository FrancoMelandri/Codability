using NUnit.Framework;

namespace CyclicRotation
{
    [TestFixture]
    public class CyclicRotationTests
    {
        private Solution sut = new Solution();
    
        [Test]
        public void ShouldReturnEmptyArray() 
        {
            Assert.IsEmpty(sut.solution(new int [] {},0));
        }
    }
}
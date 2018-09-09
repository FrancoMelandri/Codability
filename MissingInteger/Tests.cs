using NUnit.Framework;

namespace MissingInteger
{
    [TestFixture]
    public class MissingIntegerTests
    {
        Solution sut = new Solution();

        [Test]
        public void ShouldReturnOk() {
            int[] input = new int[] { };
            int result = sut.solution(input);
        
            Assert.AreEqual(0, result);
        }
    }
}